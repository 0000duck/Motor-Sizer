# Motor-Sizer

This is a C# Windows Form application. It sizes multiple axes and selects appropriate hardware for motors, gearboxes, and actuators if applicable.
It is designed to be used with Moog Animatics' product line.

### Welcome

The Welcome form acts as a window for the start of the program. Upon pressing start, the welcome window is closed.

### SizerMain

SizerMain is the main form and script for the program. The form associated with SizerMain displays the main window.

### EditTool

EditTool is a separate form used as a DialogBox when prompting an axis edit or addition in the main window.
The edit tool has fields for: torque, torque units, speed, speed units, duty cycle, thrust force, thrust force units, pitch, pitch units, rotational vs linear motion, and additional options.
The information in the EditTool window is saved whenever the window is closed.

#### Axis class

Contains axis information input by the user.

#### Motor class

Contains information for each motor: part name, frame size, continuous torque, peak torque, weight, no load speed, shaft size, communication protocols, and additional options.

#### Gearhead class
Not used at current.

#### Actuator class
Not used at current. 