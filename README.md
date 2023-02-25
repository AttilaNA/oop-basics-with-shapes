# Tasks

## Implement shapes

Implement the constructors and the required methods in shape subclasses. The shapes must be immutable. that is, their state (stored in attributes) cannot be changed.

- All attributes are immutable.

- All attributes are private, and only the methods and properties used by other classes are not private.

- All shape subclasses have an overridden version for calculating the corresponding perimeter and area.

- All shape subclasses have (or inherit) their custom @ToString() representation. The representation includes the name of the shape (such as "Rectangle") and the names and values of its base attributes (in this case "r=...").

## Shape collection

Implement ShapeCollection to manage a list of shapes. The collection can consist of any subtype of Shape.

- It is possible to add shapes to the collection using the AddShape method.

- The @GetShapesTable() method returns a printable table with all the shapes in the collection and their parameter values. The table looks like the example in table_example.txt.

- The @GetLargestShapeByPerimeter() method returns the shape instance with the largest perimeter in the collection.

- The @GetLargestShapeByArea() method returns the shape instance with the largest area in the collection.

## Main menu

Show a main menu upon starting the program that provides access to basic operations on a shape collection.

- By choosing the "Add new shape" option, the user can select from a list of existing shapes (such as circle). Then the user must specify the required parameters (such as the radius).

- By choosing the "Show all shapes" option, the table view provided by the shape collection is displayed.

- Choosing the "Show shape with the largest perimeter" option displays the shape with the largest perimeter in the collection.

- Choosing the "Show shape with the largest area" option displays the shape with the largest area in the collection

- By choosing the "Show formulas" option, the user can select from a list of existing shapes (such as circle), and the stored formulas for the shape class (such as Circle area formula: π×r×r, Circle perimeter formula: 2×π×r) are displayed.

- The user can exit the program by selecting "Exit".
