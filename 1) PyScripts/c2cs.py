import sys

if (len(sys.argv) < 3):
	print("""[HELP]
arg1 -> file input
arg2 -> file output""")

path_in = sys.argv[1]
path_out = sys.argv[2]
data = ''

with open(path_in, 'r') as file_in:
	data = file_in.readlines()

for i in range(len(data)):
	ignore_flag = False
	for j in range(1, len(data[i])):
		if data[i][j] == '\"':
			ignore_flag = not(ignore_flag)
		if not(ignore_flag) and data[i][j-1] != '_':
			byt = bytearray(data[i], "utf-8")
			byt[j] = ord(data[i][j].lower())
			data[i] = byt.decode("utf-8")
		elif not(ignore_flag):
			byt = bytearray(data[i], "utf-8")
			byt[j-1] = ord('\0')
			data[i] = byt.decode("utf-8")
	data[i] = data[i].replace('\0', '')

with open(path_out, 'w') as file_out:
	file_out.writelines(data)
