import sys

class settings:
    adress = "0x15EF035"
    ini = "BaseEngine.ini"
    ssl = "4.1.2.PTB"

def main():
    f = open(settings.ini, 'r')
    g = open("%s.ssl" % settings.ssl, 'w+')
    content = f.read()
    key = ""

    for c in content:
        value = hex(ord(c))
        if value == "0x0":
            break
        if len(value) >= 3 and value == "0xa":
            value = "0x0a"
            key += "0x0d "
        key += "%s " % value
    g.write("%s %s" % (settings.adress, key[:len(key) - 1]))

    f.close()
    g.close()

main()