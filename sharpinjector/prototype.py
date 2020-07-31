import random
import requests
import json
import sys

class settings:
    cookie        = None
    levelversion  = 0
    games_played  = 0
    url_xp = "https://steam.live.bhvrdbd.com/api/v1/extensions/playerLevels/earnPlayerXp"
    emblems = ["Bronze", "Silver", "Gold", "Iridescent"]

def health():
    response = requests.get("https://steam.live.bhvrdbd.com/api/v1/healthcheck")
    if response.json()["health"] == "Alive":
        print("Servers are responding")
    else:
        print("Servers are not responding")
        exit(-1)

def init():
    health()
    try:
        settings.levelversion = sender()["levelInfo"]["levelVersion"]
        print("Level Version: %s" % (settings.levelversion))
    except:
        print("Your bhvr cookie is incorrect")
        input("\n[ ENTER ]")
        exit (-1)

def arguments():                            
    print(" __    _     _   _                     ")
    print("|  |  |_|___| |_| |_ _____ ___ ___ ___ ")
    print("|  |__| | . |   |  _|     | .'|  _| -_|")
    print("|_____|_|_  |_|_|_| |_|_|_|__,|_| |___|")
    print("        |___|   by Neo       For 4.1.0\n")
    settings.cookie = input("Please enter your BHVR cookie: ")
    settings.games_played = int(input("Number of game to emulate: "))

def sender():
    response = requests.post(
        settings.url_xp,
        json = {
            "data": {
                "consecutiveMatch": 1,
                "emblemQualities": [
                    settings.emblems[random.randint(0, (len(settings.emblems) - 1))],
                    settings.emblems[random.randint(0, (len(settings.emblems) - 1))],
                    settings.emblems[random.randint(0, (len(settings.emblems) - 1))],
                    settings.emblems[random.randint(0, (len(settings.emblems) - 1))]
                ],
                "isFirstMatch": False,
                "levelVersion": settings.levelversion,
                "matchTime": (random.randint(0, 1000) + 1000),
                "platformVersion": "steam",
                "playerType": "survivor"
            }
        },
        headers = {
            "Accept-Encoding": "deflate, gzip",
            "Accept": "*/*",
            "Content-Type": "application/json",
        },
        cookies = {
            "bhvrSession": settings.cookie
        }).json()
    return (response)

def level():
    for i in range(0, int(settings.games_played)):
        response = sender()
        progress = "%d%c" % (((i / settings.games_played) * 100), '%')
        sentence = "Progress: %s Level: %s Devotion: %d Total xp: %s" % (progress, response["levelInfo"]["level"], response["levelInfo"]["prestigeLevel"], response["levelInfo"]["totalXp"])
        sys.stdout.write(sentence)
        sys.stdout.flush()
        sys.stdout.write('\b' * len(sentence))
        settings.levelversion += 1
    print("Progress: 100%c Level: %s Devotion: %d Total xp: %s" % ('%', response["levelInfo"]["level"], response["levelInfo"]["prestigeLevel"], response["levelInfo"]["totalXp"]))

def main():
    arguments()
    print("\n-> Initialisating...\n")
    init()
    print("\n-> Initialisation done")
    print("\n-> Injecting...\n")
    if settings.games_played > 0:
        level()
    print("\n-> Injection finished")
    input("\n[ ENTER ]")
    return (0)

main()