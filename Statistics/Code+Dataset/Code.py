import pandas as pd
import numpy as np
import matplotlib.pyplot as plt
import matplotlib
matplotlib.axes.Axes.pie
matplotlib.pyplot.pie
import statistics

# Reading the data
df = pd.read_csv("bank.csv")

print("All Column of Balance")
print(df.balance)

Q1 = df['balance'].quantile(0.25)
Q3 = df['balance'].quantile(0.75)
IQR = Q3 - Q1
print("Interqurtile Range")
print(IQR)
print("Outliers")
print(df['balance'] < (Q1 - 1.5 * IQR))or(df['balance'] > (Q3 + 1.5 * IQR))
print("Outliers with Skewness")
print(df['balance'].skew())
print(df['balance'].describe())

print('median')
print(statistics.median(df['balance']))
print('mean')
print(statistics.mean(df['balance']))
print('mode')
print(statistics.mode(df['duration']))

print('variance')
print(df['balance'].var())
print('standard deviation')
print(df['balance'].std())

plt.hist(df["balance"])
plt.show()
plt.boxplot(df["balance"])
plt.show()

df['balance'].value_counts().head(10).plot.pie(autopct='%1.1f%%')
plt.gca().set_aspect('equal')
plt.show()

fig, ax = plt.subplots(figsize=(12,6))
ax.scatter(df['balance'], df['duration'])
ax.set_xlabel('Balance')
ax.set_ylabel('Duration')
plt.show()

spread = np.random.rand(50) * 100
center = np.ones(25) * 50
flier_high = np.random.rand(10) * 100 + 100
flier_low = np.random.rand(10) * -100
data = np.concatenate((spread, center, flier_high, flier_low), 0) 
plt.figure(figsize = (7, 5)) 
plt.boxplot(data) 