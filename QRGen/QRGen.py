import urllib.request
from random import *

# replaces spaces to spaces readable by a web link
# ("%20" is the equivalent to spaces)
def spaces_to_undscr(qr):
	list_decomp = []

	list_decomp = list(qr)
	list_decomp = [w.replace(' ', '%20') for w in list_decomp]
	qr = ''.join(list_decomp)

	return qr

# user input added to API
print("Choose a link or some text to transform to a QR code")
qr = input("> ")

qr = spaces_to_undscr(qr)
qrl = "https://api.qrserver.com/v1/create-qr-code/?size=150x150&data=" + qr

# Random number generated for file name
nm = str(randint(1000,9999))

# Retrieves QR code to file location
urllib.request.urlretrieve(qrl, nm+".jpg")