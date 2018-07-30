import broadlink

broadlink.setup('SPARK-4LDFTZ', 'P7FKRAA7XS', 3)

devices = broadlink.discover(timeout=5)

#obtain authentication key for further access
for i in range(len(devices)):
    devices[i].auth()
    devices[i].set_power(not devices[i].check_power())
# class HomeController:
#     def toggleDevice(i):
#         devices[i].set_power(not devices[i].check_power())
#
#     def turnOffDevice(i):
#         if i < len(devices):
#             devices[i].set_power(False)
#
#     def turnOnDevice(i):
#         if i < len(devices):
#             devices[i].set_power(True)
#
#     def turnOffAll():
#         for i in range(len(devices)):
#             devices[i].set_power(False)
#
#     def turnOnAll():
#         for i in range(len(devices)):
#             devices[i].set_power(True)
#
#     def checkDevicePower(i):
#         if i < len(devices):
#             return devices[i].check_power();
#         else:
#             return False

