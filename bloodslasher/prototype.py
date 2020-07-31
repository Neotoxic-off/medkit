import random
import requests
import json
import sys

class settings:
    bhvr = None
    maximum = 0
    default = 0
    url = "https://steam.live.bhvrdbd.com/api/v1/extensions/rewards/grantCurrency/"

def value():
    return (random.randint(0, 1000))

def send(bp_value):
    response = requests.post(
        settings.url,
        json = {
            "data": {
                "rewardType": "Story",
                "walletToGrant": {
                    "balance": int(bp_value),
                    "currency": "Bloodpoints"
                }
            }
        },
        headers = {
            "Accept-Encoding": "deflate, gzip",
            "Accept": "*/*",
            "Content-Type": "application/json"
        },
        cookies = {
            "bhvrSession": settings.bhvr
        }
    ).json()
    print(response)

def main():
    settings.bhvr = input("Cookie: ")
    settings.maximum = int(input("Max value: "))
    settings.default = int(input("Actual bp value: "))
    limit = 0

    while settings.default < settings.maximum and settings.default <= 1000000000:
        if limit < 50:
            settings.default += value()
            if settings.default > 1000000:
                print("Goal Reached !")
                exit(0)
            else:
                limit += 1
                send(settings.default)
        else:
            print("Limit exceeded")
            exit (0)

main()