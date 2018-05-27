import matplotlib.pyplot as plt
import numpy as np

#ZADANIE1
'''
#Napiecie wejsciowe Vbe
Vbe = np.array([0.0, 0.1, 0.2, 0.3, 0.4, 0.5, 0.6, 0.7, 0.8])
#Napiecie wyjsciowe Vce=1V
Vce1 = np.array([0,0,0,0,0,0,1.4,129.2,400])
#Napiecie wyjsciowe Vce=3V
Vce3 = np.array([0,0,0,0,0,0,1.1,105.3,404])
#Napiecie wyjsciowe Vce=5V
Vbe1= np.array([0.0, 0.1, 0.2, 0.3, 0.4, 0.5, 0.6, 0.7])
Vce5 = np.array([0,0,0,0,0,0,1.1,108.3])

z1=np.polyfit(Vbe,Vce1,6)
p_1=np.poly1d(z1)
xp=np.linspace(start=0.0,stop=0.83, num=100)
p1 = plt.plot(Vbe,Vce1,'bo-', alpha=0.5,label="Wartości odnotowane Vce = 1V")
p11 = plt.plot(xp,p_1(xp),'b:',alpha=0.3,label="Krzywa dopasowania")
z2=np.polyfit(Vbe,Vce3,7)
p_2=np.poly1d(z2)
p2= plt.plot(Vbe,Vce3,'go-', alpha=0.5,label="Wartości odnotowane Vce = 3V")
p22= plt.plot(xp,p_2(xp),'g:',alpha=0.3,label="Krzywa dopasowania")
z3=np.polyfit(Vbe1,Vce5,7)
p_3=np.poly1d(z3)
p3 = plt.plot(Vbe1,Vce5,'ro-', alpha=0.5,label="Wartości odnotowane Vce = 5V")
xp1=np.linspace(start=0.0,stop=0.75, num=100)
p33 = plt.plot(xp1,p_3(xp1),'r:',alpha=0.3,label="Krzywa dopasowania")
plt.legend(loc='upper left')

plt.xlabel("Napięcie wejściowe Vbe[V]")
plt.ylabel("Prąd wejściowy Ib["+u'\u03bc'+"A] gdy Vce=const")
plt.show()
'''
'''
#ZADANIE2
#Napiecie wyjsciowe Vce
Vce=np.array([0, 0.5, 1, 2, 3, 4, 5, 6, 7, 8])
#Prad wyjściowy Ic(mA) przy stałej wartości prądu wejściowego
Ib0=np.array([0, 0, 0, 0, 0, 0, 0, 0, 0, 0])
Ib10=np.array([0, 1.07, 2.43, 2.61, 3.41, 8.13, 2.95, 3.11, 4.22, 3.61])
Ib20=np.array([0.01, 1.15, 5.32, 6.11, 6.27, 6.14, 6.17, 6.98, 6.12, 5.87])
Ib30=np.array([0.01, 1.19, 8.28, 9.47, 9.55, 9.75, 8.57, 7.08, 6.53, 6.57])
Ib40=np.array([0.02, 1.21, 12.20, 12.26, 12.03, 12.82, 12.20, 7.24, 8.12, 8.86])

z1=np.polyfit(Vce,Ib0,2)
z2=np.polyfit(Vce,Ib10,5)
z3=np.polyfit(Vce,Ib20,6)
z4=np.polyfit(Vce,Ib30,5)
z5=np.polyfit(Vce,Ib40,6)
p_1=np.poly1d(z1)
p_2=np.poly1d(z2)
p_3=np.poly1d(z3)
p_4=np.poly1d(z4)
p_5=np.poly1d(z5)
xp=np.linspace(start=0.1,stop=7.8, num=100)
#p1 = plt.plot(Vce,Ib0,color="blue",linestyle='-',marker="o", alpha=0.5,label="Wartości odnotowane Ib = 0"+u'\u03bc'+"A")
p11 = plt.plot(xp,p_1(xp),'b:',alpha=0.3)
#p2 = plt.plot(Vce,Ib10,color="aqua",linestyle='-',marker="v",alpha=0.5,label="Wartości odnotowane Ib = 10"+u'\u03bc'+"A")
p22 = plt.plot(xp,p_2(xp),'b:',alpha=0.3)
#p3 = plt.plot(Vce,Ib20,color="aquamarine",linestyle='-',marker="s", alpha=0.5,label="Wartości odnotowane Ib = 20"+u'\u03bc'+"A")
p33 = plt.plot(xp,p_3(xp),'b:',alpha=0.3)
#p4 = plt.plot(Vce,Ib30,color="teal",linestyle='-',marker="p", alpha=0.5,label="Wartości odnotowane Ib = 30"+u'\u03bc'+"A")
p44 = plt.plot(xp,p_4(xp),'b:',alpha=0.3)
#p5 = plt.plot(Vce,Ib40,color="cyan",linestyle='-',marker="x", alpha=0.5,label="Wartości odnotowane Ib = 40"+u'\u03bc'+"A")
p55 = plt.plot(xp,p_5(xp),'b:',alpha=0.3,label="Krzywe dopasowania")

plt.subplots_adjust(wspace=20)
plt.legend(loc='upper right')
plt.xlabel("Napięcie wejściowe Vce[V]")
plt.ylabel("Prąd wyjściowy Ic[mA] gdy Ib=const")
plt.show()
'''
#ZADANIE3
Ib=np.array([0, 10, 20, 30, 40, 50, 60, 70, 80, 90, 100])
Ic=np.array([0, 3.60, 6.03, 9.76, 13.60, 17.60, 20.68, 24.39, 28.35, 31.22, 35.79])
z1=np.polyfit(Ib,Ic,2)
p_1=np.poly1d(z1)
xp=np.linspace(start=0.0,stop=100, num=100)
p1 = plt.plot(Ib,Ic,color="blue",linestyle='-',marker="o", alpha=0.5,label="Charakterystyka przejściowa tranzystora")
p11 = plt.plot(xp,p_1(xp),'r:',alpha=0.7,label="Krzywa dopasowania")
plt.legend(loc='upper left')
plt.xlabel("Prąd wejściowy Ib["+u'\u03bc'+"A]")
plt.ylabel("Prąd wyjściowy Ic[mA] gdy Vce=max")
plt.show()
