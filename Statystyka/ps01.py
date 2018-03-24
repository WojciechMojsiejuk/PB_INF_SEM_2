import random
import numpy as np
import statistics as st
import matplotlib.pyplot as plt

data = []
miejsce = [] #0 - wies 1 - miasto
dochod = []
czas_pracy = []
for i in range(100):
    if i<=49: miejsce.append(1)
    else: miejsce.append(0)
    if miejsce[-1]==0:
        dochod.append(random.randrange(1500,3000))
    else:
        dochod.append(random.randrange(1800,4000))
    if dochod[-1] in range(1500,2200):
        czas_pracy.append(random.randrange(6,9))
    else:
        czas_pracy.append(random.randrange(8,11))
data = [(miejsce[i], dochod[i], czas_pracy[i]) for i in range(100)]

min_dochod = min(dochod)
max_dochod = max(dochod)
min_czas_pracy = min(czas_pracy)
max_czas_pracy = max(czas_pracy)
range_dochod = max_dochod - min_dochod
range_czas_pracy = max_czas_pracy - min_czas_pracy
mean_dochod = round(np.mean(dochod),2)
mean_czas_pracy = round(np.mean(czas_pracy),2)
median_dochod = st.median(dochod)
median_czas = st.median(czas_pracy)

print("\nTotal:\n")
print(
    "\tMinimalny dochod: ",min_dochod, "\t\t\t\tMaksymalny dochod:",max_dochod,"\n",
"\tMinimalny czas pracy: ",min_czas_pracy,"\t\t\t\tMaksymalny czas pracy: ",max_czas_pracy,"\n",
    "\tRozstep dochodow: ",range_dochod,"\t\t\t\tRozstep czasu: ", range_czas_pracy,"\n",
    "\tSredni dochod: ",mean_dochod, "\t\t\t\tSredni czas pracy: ", mean_czas_pracy,'\n',
    "\tMediana dochodu: ",median_dochod, "\t\t\t\tMediana czasu: ",median_czas)
mode_dochod=-1
mode_czas=-1
try:
    mode_dochod = st.mode(dochod)
    mode_czas = st.mode(czas_pracy)
except st.StatisticsError:
    print ("\nNo unique mode found\n")
variance_dochod = round(st.variance(dochod),2)
variance_czas = round(st.variance(czas_pracy),2)
stdev_dochod = round(st.stdev(dochod),2)
stdev_czas = round(st.stdev(czas_pracy),2)
q1_dochod = np.percentile(dochod,25)
q1_czas = np.percentile(czas_pracy,25)
q3_dochod = np.percentile(dochod,75)
q3_czas = np.percentile(czas_pracy,75)
iqr_dochod = q3_dochod-q1_dochod
iqr_czas = q3_czas-q1_czas
print(
    "\tModa dochodu: ", mode_dochod,"\t\t\t\tModa czasu: ",mode_czas,"\n",
    "\tWariancja dochodu: ", variance_dochod,"\t\t\t\tWariancja czasu: ",variance_czas,"\n",
    "\tOdchylenie dochodu: ",stdev_dochod,"\t\t\t\tOdchylenie czasu: ",stdev_czas,"\n",
    "\tKwartyl dolny dochodu: ",q1_dochod,"\t\t\t\tKwartyl dolny czasu: ",q1_czas,"\n",
    "\tKwartyl gorny dochodu: ",q3_dochod,"\t\t\t\tKwartyl gorny czasu: ",q3_czas,"\n"
    "\r Roz kwartylowy dochodu: ",iqr_dochod,"\t\t\t\tRoz kwartylowy czasu: ",iqr_czas,"\n"
)



min_dochod = min(dochod[50:])
max_dochod = max(dochod[50:])
min_czas_pracy = min(czas_pracy[50:])
max_czas_pracy = max(czas_pracy[50:])
range_dochod = max_dochod - min_dochod
range_czas_pracy = max_czas_pracy - min_czas_pracy
mean_dochod = round(np.mean(dochod[50:]),2)
mean_czas_pracy = round(np.mean(czas_pracy[50:]),2)
median_dochod = st.median(dochod[50:])
median_czas = st.median(czas_pracy[50:])

print("\nWies:\n")
print(
    "\tMinimalny dochod: ",min_dochod, "\t\t\t\tMaksymalny dochod:",max_dochod,"\n",
"\tMinimalny czas pracy: ",min_czas_pracy,"\t\t\t\tMaksymalny czas pracy: ",max_czas_pracy,"\n",
    "\tRozstep dochodow: ",range_dochod,"\t\t\t\tRozstep czasu: ", range_czas_pracy,"\n",
    "\tSredni dochod: ",mean_dochod, "\t\t\t\tSredni czas pracy: ", mean_czas_pracy,'\n',
    "\tMediana dochodu: ",median_dochod, "\t\t\t\tMediana czasu: ",median_czas)
mode_dochod=-1
mode_czas=-1
try:
    mode_dochod = st.mode(dochod[50:])
    mode_czas = st.mode(czas_pracy[50:])
except st.StatisticsError:
    print ("\nNo unique mode found\n")
variance_dochod = round(st.variance(dochod[50:]),2)
variance_czas = round(st.variance(czas_pracy[50:]),2)
stdev_dochod = round(st.stdev(dochod[50:]),2)
stdev_czas = round(st.stdev(czas_pracy[50:]),2)
q1_dochod = np.percentile(dochod[50:],25)
q1_czas = np.percentile(czas_pracy[50:],25)
q3_dochod = np.percentile(dochod[50:],75)
q3_czas = np.percentile(czas_pracy[50:],75)
iqr_dochod = q3_dochod-q1_dochod
iqr_czas = q3_czas-q1_czas
print(
    "\tModa dochodu: ", mode_dochod,"\t\t\t\tModa czasu: ",mode_czas,"\n",
    "\tWariancja dochodu: ", variance_dochod,"\t\t\t\tWariancja czasu: ",variance_czas,"\n",
    "\tOdchylenie dochodu: ",stdev_dochod,"\t\t\t\tOdchylenie czasu: ",stdev_czas,"\n",
    "\tKwartyl dolny dochodu: ",q1_dochod,"\t\t\t\tKwartyl dolny czasu: ",q1_czas,"\n",
    "\tKwartyl gorny dochodu: ",q3_dochod,"\t\t\t\tKwartyl gorny czasu: ",q3_czas,"\n"
    "\r Roz kwartylowy dochodu: ",iqr_dochod,"\t\t\t\tRoz kwartylowy czasu: ",iqr_czas,"\n"
)



min_dochod = min(dochod[:50])
max_dochod = max(dochod[:50])
min_czas_pracy = min(czas_pracy[:50])
max_czas_pracy = max(czas_pracy[:50])
range_dochod = max_dochod - min_dochod
range_czas_pracy = max_czas_pracy - min_czas_pracy
mean_dochod = round(np.mean(dochod[:50]),2)
mean_czas_pracy = round(np.mean(czas_pracy[:50]),2)
median_dochod = st.median(dochod[:50])
median_czas = st.median(czas_pracy[:50])

print("\nMiasto:\n")
print(
    "\tMinimalny dochod: ",min_dochod, "\t\t\t\tMaksymalny dochod:",max_dochod,"\n",
"\tMinimalny czas pracy: ",min_czas_pracy,"\t\t\t\tMaksymalny czas pracy: ",max_czas_pracy,"\n",
    "\tRozstep dochodow: ",range_dochod,"\t\t\t\tRozstep czasu: ", range_czas_pracy,"\n",
    "\tSredni dochod: ",mean_dochod, "\t\t\t\tSredni czas pracy: ", mean_czas_pracy,'\n',
    "\tMediana dochodu: ",median_dochod, "\t\t\t\tMediana czasu: ",median_czas)
mode_dochod=-1
mode_czas=-1
try:
    mode_dochod = st.mode(dochod[:50])
    mode_czas = st.mode(czas_pracy[:50])
except st.StatisticsError:
    print ("No unique mode found")
variance_dochod = round(st.variance(dochod[:50]),2)
variance_czas = round(st.variance(czas_pracy[:50]),2)
stdev_dochod = round(st.stdev(dochod[:50]),2)
stdev_czas = round(st.stdev(czas_pracy[:50]),2)
q1_dochod = np.percentile(dochod[:50],25)
q1_czas = np.percentile(czas_pracy[:50],25)
q3_dochod = np.percentile(dochod[:50],75)
q3_czas = np.percentile(czas_pracy[:50],75)
iqr_dochod = q3_dochod-q1_dochod
iqr_czas = q3_czas-q1_czas
print(
    "\tModa dochodu: ", mode_dochod,"\t\t\t\tModa czasu: ",mode_czas,"\n",
    "\tWariancja dochodu: ", variance_dochod,"\t\t\t\tWariancja czasu: ",variance_czas,"\n",
    "\tOdchylenie dochodu: ",stdev_dochod,"\t\t\t\tOdchylenie czasu: ",stdev_czas,"\n",
    "\tKwartyl dolny dochodu: ",q1_dochod,"\t\t\t\tKwartyl dolny czasu: ",q1_czas,"\n",
    "\tKwartyl gorny dochodu: ",q3_dochod,"\t\t\t\tKwartyl gorny czasu: ",q3_czas,"\n"
    "\r Roz kwartylowy dochodu: ",iqr_dochod,"\t\t\t\tRoz kwartylowy czasu: ",iqr_czas,"\n"
)
f = open('dane.txt','w')
for i in range(100):
    line = str(miejsce[i])+","+str(dochod[i])+","+str(czas_pracy[i])+"\n"
    f.writelines(line)
f.close()
bx1_dochod = [dochod[:50]]
plt.boxplot(bx1_dochod)
#"1 dochody w mieście"
plt.title("Boxplot dochodow w miescie")
plt.show()

bx2_dochod = [dochod[50:]]
plt.boxplot(bx2_dochod)
#"1 dochody na wsi"
plt.title("Boxplot dochodow na wsi")
plt.show()

bx_dochod = [dochod[:50], dochod[50:]]
plt.boxplot(bx_dochod)
#"1 - dochody wszystkich 2 - dochody w mieście 3 - dochody na wsi"
plt.title("Boxplot dochodow na wsi i w miescie")
plt.legend()
plt.show()

bx3_dochod = [dochod]
plt.boxplot(bx3_dochod)
#"1 - dochody wszystkich 2 - dochody w mieście 3 - dochody na wsi"
plt.title("Boxplot dochodow (w sumie)")
plt.legend()
plt.show()

##########################################################

bins_edges=[1500,1750,2000,2250,2500,2750,3000,3250,3500,3750,4000]
h1_dochod = [dochod[:50]]
plt.hist(h1_dochod,bins=bins_edges)
plt.ylabel("Liczba osób")
plt.xlabel("Dochody (zł)")
plt.title("Histogram dochodow w miescie")
plt.show()

h2_dochod = [dochod[50:]]
plt.hist(h2_dochod,bins=bins_edges)
plt.ylabel("Liczba osób")
plt.xlabel("Dochody (zł)")
plt.title("Histogram dochodow na wsi")
plt.show()

h_dochod = [dochod[:50], dochod[50:]]
plt.hist(h_dochod,bins=bins_edges)
plt.ylabel("Liczba osób")
plt.xlabel("Dochody (zł)")
plt.title("Histogram dochodow na wsi i w miescie")
plt.show()

h3_dochod = [dochod]
plt.hist(h3_dochod,bins=bins_edges)
plt.ylabel("Liczba osób")
plt.xlabel("Dochody (zł)")
plt.title("Histogram dochodow (w sumie)")
plt.show()

##########################################################

bx1_czas=[czas_pracy[:50]]
plt.title("Boxplot czasu pracy w miescie")
plt.boxplot(bx1_czas)
plt.show()


bx2_czas=[czas_pracy[50:]]
plt.title("Boxplot czasu pracy na wsi")
plt.boxplot(bx2_czas)
plt.show()

bx_czas=[czas_pracy[:50], czas_pracy[50:]]
plt.title("Boxplot czasu pracy na wsi i w miescie")
plt.boxplot(bx_czas)
plt.show()

bx3_czas=[czas_pracy]
plt.title("Boxplot czasu pracy (w sumie)")
plt.boxplot(bx3_czas)
plt.show()

##########################################################

h1_czas = [czas_pracy[:50]]
bins_edges=[6,7,8,9,10,11]
plt.hist(h1_czas,bins=bins_edges,range=[6,11], density=False)
plt.ylabel("Liczba osób")
plt.xlabel("Czas pracy (h)")
plt.title("Histogram czasu pracy w miescie")
plt.show()

h2_czas = [czas_pracy[50:]]
bins_edges=[6,7,8,9,10,11]
plt.hist(h2_czas,bins=bins_edges,range=[6,11], density=False)
plt.ylabel("Liczba osób")
plt.xlabel("Czas pracy (h)")
plt.title("Histogram czasu pracy na wsi")
plt.show()

h_czas = [czas_pracy[:50], czas_pracy[50:]]
bins_edges=[6,7,8,9,10,11]
plt.hist(h_czas,bins=bins_edges,range=[6,11], density=False)
plt.ylabel("Liczba osób")
plt.xlabel("Czas pracy (h)")
plt.title("Histogram czasu pracy na wsi i w miescie")
plt.show()


h3_czas = [czas_pracy]
bins_edges=[6,7,8,9,10,11]
plt.hist(h3_czas,bins=bins_edges,range=[6,11], density=False)
plt.ylabel("Liczba osób")
plt.xlabel("Czas pracy (h)")
plt.title("Histogram czasu pracy (w sumie)")
plt.show()
