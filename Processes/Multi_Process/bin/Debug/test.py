import time
import sys

with open("arguman_dosyasi.txt", "r") as dosya:
    arguman_listesi = []
    for i in dosya.readlines():
        print(i)
        arguman_listesi.append(int(i))
    dosya.close()

print(arguman_listesi)
a = sum(arguman_listesi)

with open("sonuc_dosyasi.txt", "w") as dos:
    dos.write(str(a))
    dos.close()

time.sleep(2)