from sklearn.model_selection import train_test_split
from sklearn.datasets import load_iris
import matplotlib.pyplot as plt
import seaborn as sns
import pandas as pd
import numpy as np
from sklearn.linear_model import LinearRegression, LogisticRegressionCV
from sklearn.neighbors import KNeighborsClassifier
import time

with open("parametreler.log", "r") as parametreler:
        KNN = eval(parametreler.readline())
        print(KNN)
        print(KNN["neig"])
        parametreler.close()

veri = load_iris()
X = veri["data"]
Y = veri["target"]

x_train, x_test, y_train, y_test = train_test_split(X,Y, test_size=float(KNN["size_test"]), 
                random_state=KNN["random_state"])
model_knn = KNeighborsClassifier(n_neighbors=KNN["neig"])

model_knn.fit(x_train, y_train)

y_pred = model_knn.predict(x_test)

from sklearn.metrics import confusion_matrix

cm = confusion_matrix(y_test, y_pred)

plt.subplot(121)
#plt.figure(figsize=(4,3))
sns.heatmap(cm, annot=True,cmap="Greens",linecolor="gray")
plt.title("Confusion Matrix")
plt.subplot(122)
plt.plot(y_pred, label = "Tahmin", color="red", marker = "o")
plt.plot(y_test, label = "Gerçek", color="green")
plt.title("Karşılaştırma")
plt.legend()
plt.show()
plt.savefig("SONUCLAR.png")
                                    

def LM():
    
    LM = {"size_test" : 0.2, "at_name" : "Linear"}
    veri = load_iris()
    X = veri["data"]
    Y = veri["target"]

    x_train, x_test, y_train, y_test = train_test_split(X,Y, test_size=KNN["size_test"], 
                                                        random_state=KNN["random_state"])
    model_knn = LogisticRegressionCV()

    model_knn.fit(x_train, y_train)

    y_pred = model_knn.predict(x_test)

    from sklearn.metrics import confusion_matrix

    cm = confusion_matrix(y_test, y_pred)

    plt.subplot(121)
    #plt.figure(figsize=(4,3))
    sns.heatmap(cm, annot=True,cmap="Greens",linecolor="gray")
    plt.title("Confusion Matrix")
    plt.subplot(122)
    plt.plot(y_pred, label = "Tahmin", color="red", marker = "o")
    plt.plot(y_test, label = "Gerçek", color="green")
    plt.title("Karşılaştırma")
    plt.legend()
    plt.show()
    plt.savefig("SONUCLAR.png")

def calis():
    if KNN["model"] == 1:
        LM()
    else:
        pass

calis()