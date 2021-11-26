<!DOCTYPE html>
    <html>

        <head>
        <meta name="viewport" content="width=device-width, initial-scale=1">
<style>
h2.header {
  text-align: center;
}

body {font-family: Arial, Helvetica, sans-serif;}
* {box-sizing: border-box;}

.form-inline {  
  display: flex;
  flex-flow: row wrap;
  align-items: center;
  margin: auto;
  text-align: center;
  width: 650px;
}

.form-inline label {
  margin: 5px 10px 5px 0;
}

.form-inline input {
  vertical-align: middle;
  margin: 5px 10px 5px 0;
  padding: 10px;
  background-color: #fff;
  border: 1px solid #ddd;
}

.form-inline button {
  padding: 10px 20px;
  background-color: dodgerblue;
  border: 1px solid #ddd;
  color: white;
  cursor: pointer;
}

.form-inline button:hover {
  background-color: royalblue;
}

@media (max-width: 800px) {
  .form-inline input {
    margin: 10px 0;
  }
  
  .form-inline {
    flex-direction: column;
    align-items: center;
  }
}
</style>
            <title>Manage Performances</title>
                <style>
                    table {
                        border-collapse: collapse;
                        width: 75%;
                        color: #000000;
                        font-family: arial;
                        font-size: auto;
                        text-align: center;
                        margin-left: auto;
                        margin-right: auto;
                        }
                    th {
                        background-color: #000000;
                        color: white;
                    }
                    tr:nth-child(even) {background-color: #D3D3D3}
                </style>
            </head>
        <body>
<body>
    <h2 class="header"> Add New Performance </h2>
    <form class="form-inline">
    <label for="teacher">ProgramID:
            <select name="teacher" id="teacher">
                <option value="Teacher">1</option>
            </select>
            </label>
            <label for="teacher">Group:
            <select name="teacher" id="teacher">
                <option value="Teacher">The Best Group</option>
            </select>
            </label>
            <label for="teacher">Pieces:
            <select name="teacher" id="teacher" multiple>
                <option value="Teacher">Piece Zero</option>
                <option value="Teacher">Piece One</option>
                <option value="Teacher">Piece Two</option>
                <option value="Teacher">Piece Three</option>
            </select>
            </label>
        <button type="submit">Submit</button>
    </form>

</body>
            <table>
                <tr>
                    <th>ProgramID</th>
                    <th>Group</th>
                    <th>Piece</th>
                    <th> </th>
                </tr>
            <?php
                for ($x = 0; $x <= 8; $x++) {
                    echo "<tr><td>" . "Program " . $x . "</td>
                    <td>" . "Group " . $x . "</td>
                    <td>". "Piece " . rand(1, 50) . ", " . "Piece " . rand(1, 50) . "</td>
                    <td> <input type = submit value = " . "Delete" . " class = submitbutton></td></tr>";
                }
            echo "</table>";
            ?>
        </table>
    </body>
</html>