import matplotlib.pyplot as plt
import numpy as np
x = np.array([0, 1, 2, 3, 4, 5, 6, 7, 8])
y = np.array([1, 2, 3, 5, 4, 6, 8, 7, 9])

coeffs = np.polyfit(x, y, 1)
print(coeffs)  # Y = mX + b

m = coeffs[0]
b = coeffs[1]

est_y = (m * x) + b


plt.plot(x, est_y)
plt.scatter(x, y)
plt.show()
