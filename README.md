# Motor-Sizer

This is a C# Windows Form application. It sizes multiple axes and selects appropriate hardware for motors, gearboxes, and actuators if applicable.
It is designed to be used with Moog Animatics' product line.

The sizer can recommend motors for multiple axes and call them based on the exact part numbers:
<img src="https://live.staticflickr.com/65535/48011518892_425e697ec2.jpg">

It also recommends a gearhead by part number when applicable:
<img src="https://live.staticflickr.com/65535/48011518892_425e697ec2.jpg" width="500" height="300">

### "Welcome" Form

The Welcome form acts as a window for the start of the program. Upon pressing start, the welcome window is closed.

### "SizerMain" Form

SizerMain is the main form and script for the program. The form associated with SizerMain displays the main window. Once axes information is entered through the Edit Tool, the axis names appear in the main window.

<img src="https://live.staticflickr.com/65535/48011518972_4f040a0231.jpg" width="500" height="297">

### "EditTool" Form

EditTool is a separate form used as a DialogBox when prompting an axis edit or addition in the main window.
The edit tool has fields for many inputs.
The information in the EditTool window is saved whenever the window is closed.

<img src="https://live.staticflickr.com/65535/48016671537_53cca970c6.jpg" width="500" height="477">

#### Axis class

Contains axis information input by the user.

#### Motor class

Contains information for each motor: part name, frame size, continuous torque, peak torque, weight, no load speed, shaft size, communication protocols, and additional options.

#### Gearhead class
Not used at current.

#### Actuator class
Not used at current. 