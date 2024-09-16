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
	data[i] = data[i].replace(' SDL_', ' ')

with open(path_out, 'w') as file_out:
	file_out.writelines(data)
