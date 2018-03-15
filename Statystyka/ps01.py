import random
import numpy as np
import statistics as st
import matplotlib.pyplot as plt
data = []
miejsce = [] #0 - wies 1 - miasto
dochod = []
czas_pracy = []
for i in range(60):
    if i<30: miejsce.append(1)
    else: miejsce.append(0)
    if miejsce[-1]==0:
        dochod.append(random.randrange(1500,3000))
    else:
        dochod.append(random.randrange(1800,4000))
    if dochod[-1] in range(1500,2200):
        czas_pracy.append(round(random.uniform(6,9),0))
    else:
        czas_pracy.append(round(random.uniform(8,11),0))
data = [(miejsce[i], dochod[i], czas_pracy[i]) for i in range(60)]
print(data)

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



min_dochod = min(dochod[30:])
max_dochod = max(dochod[30:])
min_czas_pracy = min(czas_pracy[30:])
max_czas_pracy = max(czas_pracy[30:])
range_dochod = max_dochod - min_dochod
range_czas_pracy = max_czas_pracy - min_czas_pracy
mean_dochod = round(np.mean(dochod[30:]),2)
mean_czas_pracy = round(np.mean(czas_pracy[30:]),2)
median_dochod = st.median(dochod[30:])
median_czas = st.median(czas_pracy[30:])

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
    mode_dochod = st.mode(dochod[30:])
    mode_czas = st.mode(czas_pracy[30:])
except st.StatisticsError:
    print ("\nNo unique mode found\n")
variance_dochod = round(st.variance(dochod[30:]),2)
variance_czas = round(st.variance(czas_pracy[30:]),2)
stdev_dochod = round(st.stdev(dochod[30:]),2)
stdev_czas = round(st.stdev(czas_pracy[30:]),2)
q1_dochod = np.percentile(dochod[30:],25)
q1_czas = np.percentile(czas_pracy[30:],25)
q3_dochod = np.percentile(dochod[30:],75)
q3_czas = np.percentile(czas_pracy[30:],75)
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



min_dochod = min(dochod[:29])
max_dochod = max(dochod[:29])
min_czas_pracy = min(czas_pracy[:29])
max_czas_pracy = max(czas_pracy[:29])
range_dochod = max_dochod - min_dochod
range_czas_pracy = max_czas_pracy - min_czas_pracy
mean_dochod = round(np.mean(dochod[:29]),2)
mean_czas_pracy = round(np.mean(czas_pracy[:29]),2)
median_dochod = st.median(dochod[:29])
median_czas = st.median(czas_pracy[:29])

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
    mode_dochod = st.mode(dochod[:29])
    mode_czas = st.mode(czas_pracy[:29])
except st.StatisticsError:
    print ("No unique mode found")
variance_dochod = round(st.variance(dochod[:29]),2)
variance_czas = round(st.variance(czas_pracy[:29]),2)
stdev_dochod = round(st.stdev(dochod[:29]),2)
stdev_czas = round(st.stdev(czas_pracy[:29]),2)
q1_dochod = np.percentile(dochod[:29],25)
q1_czas = np.percentile(czas_pracy[:29],25)
q3_dochod = np.percentile(dochod[:29],75)
q3_czas = np.percentile(czas_pracy[:29],75)
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


bx_dochod = [dochod, dochod[:29], dochod[30:]]
plt.boxplot(bx_dochod)
#"1 - dochody wszystkich 2 - dochody w mieście 3 - dochody na wsi"
plt.title("Boxplot dochodow")
plt.show()
h_dochod = [dochod[:29], dochod[30:]]
plt.hist(h_dochod)
plt.ylabel("Liczba osób")
plt.xlabel("Dochody (zł)")
plt.title("Histogram dochodow")
plt.show()
bx_czas=[czas_pracy,czas_pracy[:29],czas_pracy[30:]]
plt.boxplot(bx_czas)
#"1 - dochody wszystkich 2 - dochody w mieście 3 - dochody na wsi"
plt.title("Boxplot czasu")
plt.show()
h_dochod = [czas_pracy[:29], czas_pracy[30:]]
plt.hist(h_dochod)
plt.ylabel("Liczba osób")
plt.xlabel("Czas pracy (h)")
plt.title("Histogram czasu pracy")
plt.show()
