import requests

name = "enter name"

resp = requests.get("https://api.cloutflare.tech/check?name=" + name)
if resp.status_code == 404:
    print("[TAKEN] " + name)
elif resp.status_code == 200:
    print("[HIT] " + name)
else:
    print("[ERROR] " + name)
