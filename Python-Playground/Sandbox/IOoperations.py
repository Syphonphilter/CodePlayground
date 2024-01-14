import os
import re

file_path = '../requirements.txt'  # Replace this with the path to your file

# Get the size of the file in bytes
file_size = os.path.getsize(file_path)

print(file_size)

## Get byte count of a given file 
def getBytes(filename):
    with open(filename, 'r') as logfile:
        for line in logfile:
            #127.0.0.1 - - [07/Jan/2024:12:01:00 +0000] "GET /files/document1.txt HTTP/1.1" 200 1500
            regexGET = re.compile(r'GET\s+.*?\s+HTTP/\d\.\d"\s+(\d+)\s+(\d+)')
            bytesCount = re.search(regexGET, line)[1]
            print("Bytes transfered: "+bytesCount)
