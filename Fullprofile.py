from Crypto.Cipher import AES
import json
import requests
import base64
import zlib

def decode():
    f = open("save.txt", 'r')
    bin = f.read()[8:]
    cipher = AES.new(b"5BCC2D6A95D4DF04A005504E59A9B36E", AES.MODE_ECB)
    profile = base64.b64decode(bin)
    print(profile)
    profile = cipher.decrypt(profile)
    profile = "".join([chr(c + 1) for c in profile]).replace("\u0001", "")
    profile = base64.b64decode(profile[8:])
    profile = profile[4:len(profile)]
    profile = zlib.decompress(profile).decode("utf16")
    profile = json.loads(profile)
    print(profile)
    with open("profile.json", "w+") as file:
        json.dump(profile, file)

def main():
    arguments()
    print("\n-> Injecting...\n")
    decode()
    print("\n-> Injection finished")
    input("\n[ ENTER ]")
    return (0)

main()