param($installPath, $toolsPath, $package, $project)
function Resolve-ProjectName {
    param(
        [parameter(ValueFromPipelineByPropertyName = $true)]
        [string[]]$ProjectName
    )
    
    if($ProjectName) {
        $projects = Get-Project $ProjectName
    }
    else {
        # All projects by default
        $projects = Get-Project
    }
    
    $projects
}
function Get-MSBuildProject {
    param(
        [parameter(ValueFromPipelineByPropertyName = $true)]
        [string[]]$ProjectName
    )
    Process {
        (Resolve-ProjectName $ProjectName) | % {
            $path = $_.FullName
            @([Microsoft.Build.Evaluation.ProjectCollection]::GlobalProjectCollection.GetLoadedProjects($path))[0]
        }
    }
}
function Remove-Import {
    param(
        [parameter(Position = 0, Mandatory = $true)]
        [string]$Path,
        [parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [string[]]$ProjectName
    )
    Process {
        (Resolve-ProjectName $ProjectName) | %{
            $buildProject = $_ | Get-MSBuildProject
            $importToRemove = $buildProject.Xml.Imports | Where-Object { $_.Project.Endswith($Path) }
            $buildProject.Xml.RemoveChild($importToRemove)
            $_.Save()
        }
    }
}
Remove-Import "Landpy.Obfuscator.targets" $project.ProjectName