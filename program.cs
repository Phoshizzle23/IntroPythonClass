import time

"""Exercise 1:
Write a program to calculate net salary for employees.
Take input for the employee name, number of hours and their hourly rate."""

######
#CODE#
######
"""
HOURLY_RATE = int(25)

name = input("What is your name?: ")
week_salary = input("What the total hours worked this week?: ")

def net_salary():
    salary = (HOURLY_RATE * int(week_salary))
    print(f"Hello {name} you earned ${salary} this week, you rich bitch!!!")
    return


net_salary()
"""
####################################################################################################
"""Exercise 2: 
Write a program to calculate the area of a rectangle. 
Take inputs for the appropriate variables. 
"""
######
#CODE#
######
"""
print("Welcome you bitch! This program calculates the area of a rectangle")
time.sleep(2)
print("So hurry up and enter you shit!!!")
time.sleep(2)
side_1 = input("Enter the first side: ")
time.sleep(2)
side_2 = input("Now enter the second side: ")
time.sleep(2)
units_of_measure_rec = input("Enter the unit of measure ie: Cm or M: ")


def area_of_rectangle():
    rec_area = (int(side_1) * int(side_2))
    print(f"{rec_area}{units_of_measure_rec}")
    return


area_of_rectangle()
"""

####################################################################################################
"""
Exercise 3: 
Write a program to calculate the area of a circle. Take inputs for the appropriate variables. 
"""
######
#CODE#
######
"""
PI_CONST = int(3.1415926535897932384626433832795028841972)

print("Welcome you bitch! This program calculates the area of a circle")
time.sleep(2)
print("So hurry up and enter you shit!!!")
time.sleep(2)
side_1 = input("Enter the radius of the circle: ")
time.sleep(2)
units_of_measure_cir1 = input("Enter the unit of measure ie: Cm or M: ")


def area_of_circle():
    circle_area = (int(side_1) * *2 * PI_CONST)
    print(f"{circle_area}{units_of_measure_cir1}")


area_of_circle()
"""

"""
import math

PI = math.pi

def area_of_circle(radius):
  #Calculates the area of a circle.
  try:
    radius = float(radius)
  except ValueError:
    print("Invalid radius.")
    return

  circle_area = PI * radius * *2
  return circle_area


def main():
  radius = input("Enter the radius of the circle: ")
  units_of_measure_cir2 = input("Enter the unit of measure ie: Cm or M: ")

  circle_area = area_of_circle(radius)
  print(f"The area of the circle is {circle_area}{units_of_measure_cir2}")


if __name__ == "__main__":
  main()
  """
####################################################################################################
"""
Exercise 4: 
Write a program to calculate the area and volume of a cylinder. 
Take inputs for the appropriate variables.
"""
######
#CODE#
######
"""
import math

PI = math.pi


def area_of_cylinder(radius, height):
  #Calculates the area of a cylinder.
  
  try:
    radius = float(radius)
    height = float(height)
  except ValueError:
    print("Invalid radius or height.")
    return

  cylinder_area = 2 * PI * radius * (radius + height)
  return cylinder_area


def volume_of_cylinder(radius, height):
  #Calculates the volume of a cylinder.
  try:
    radius = float(radius)
    height = float(height)
  except ValueError:
    print("Invalid radius or height.")
    return

  cylinder_volume = PI * radius * *2 * height
  return cylinder_volume


def main():
  cylinder_radius = input("Enter the radius of the cylinder: ")
  cylinder_height = input("Enter the height of the cylinder: ")
  units_of_measure_cylinder = input("Enter the unit of measure ie: Cm or M: ")

  cylinder_area = area_of_cylinder(cylinder_radius, cylinder_height)
  print(f"The area of the cylinder is {cylinder_area:.2f} {units_of_measure_cylinder}")

  cylinder_volume = volume_of_cylinder(cylinder_radius, cylinder_height)
  print(f"The volume of the cylinder is {cylinder_volume:.2f} {units_of_measure_cylinder}")


if __name__ == "__main__":
  main()

"""
###################################################################################################
"""
Exercise 5: 
Write code that takes inputs for a variable named minutes,
which holds minutes worked on a job, and assigns a value.
Output the value in hours and minutes; for example:  

 197 minutes becomes 3 hours and 17 minutes.
"""
######
#CODE#
######
"""
minutes = input("How many minutes did you work for?: ")

def convert_minutes_to_hours():
    hours_worked = int(minutes) / 60
    print(f"You worked for {hours_worked} hours")
    return


convert_minutes_to_hours()


def convert_minutes_to_hours_and_minutes():
  #Converts minutes to hours and minutes
  minutes = input("How many minutes did you work for?: ")
  hours_worked = round(int(minutes) / 60, 0)
  minutes_left = int(minutes) % 60
  print(f"You worked for {hours_worked} hours and {minutes_left} minutes")
  return


if __name__ == "__main__":
  convert_minutes_to_hours_and_minutes()
"""
###################################################################################################
"""
Exercise 6: 

Write code that takes input and declares a variable to represent temperature in Fahrenheit(F).
Calculate and display the equivalent temperature in Celsius(C) by applying the following formula:
    C = (F - 32) * 5 / 9

Display both values.For example:  

Fahrenheit: 89.6

Celsius: 32
"""


"""
def Convert_to_celsius():
    temp_F = float(input("What is the temp in F?: "))
    converted_A = temp_F - 32
    converted_B = converted_A * 5 / 9
    print(converted_B)
    return

Convert_to_celsius()
"""

"""
def convert_to_celsius():
  #Converts Fahrenheit to Celsius
  temp_f = float(input("What is the temperature in Fahrenheit?: "))
  converted_c = (temp_f - 32) * 5 / 9
  print(f"The temperature in Celsius is {converted_c}")
  return


if __name__ == "__main__":
  convert_to_celsius()
"""