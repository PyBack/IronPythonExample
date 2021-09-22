import sys
import base64
# import pandas as pd

print("Python Version")
print(sys.version)

def getPythonFunc():
    originalString = "Hello World!"
    print("Original string: " + originalString)

    encodedString = base64.b64encode(originalString)
    print("Encoded string: " + encodedString)

    decodedString = base64.b64decode(encodedString)
    print("Decoded string: " + decodedString)
    return originalString

def sum(a, b):
    return a + b

print("hello iron python")