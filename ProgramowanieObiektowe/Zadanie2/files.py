name = input("Podaj nazwe pliku ")
file = open(name+".txt")
file_to_save = open(name+"max.txt", 'w')
accuracy = []
try:
    for line in file:
        words = line.split(' ')
        accuracy.append(words[3])
    file.seek(0)
    for line in file:
        words = line.split(' ')
        if(float(words[3])==float((max(accuracy))) and len(words[0])>=3 and words[1][-3:]=="ski"):
            a=[]
            a.append(words[0][0])
            for i in range(len(words[0])-4):
                a.append('*')
            if(len(words[0])==3):
                a.append(words[0][-2:])
            else:
                a.append(words[0][-3:])
            answer=''.join(a)
            file_to_save.write(answer+' ')
            a.clear()
            a.append(words[1][0])
            for i in range(len(words[1]) - 4):
                a.append('*')
            if (len(words[1]) == 3):
                a.append(words[1][-2:])
            else:
                a.append(words[1][-3:])
            answer = ''.join(a)
            file_to_save.write(answer)
            file_to_save.write(' '+words[2])

except:
    print("blad pliku")
