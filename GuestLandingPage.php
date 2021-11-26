<!DOCTYPE html>
        <html>
        <head>
                <title>Program List</title>
                        <style>
                                table {
                                        border-collapse: collapse;
                                        width: 30%;
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
                        <table>
                                <tr>
                                        <th>ProgramID</th>
                                        <th>Number Of Performers</th>
                                        </tr>
                                                <?php
                                                        for ($x = 0; $x <= 8; $x++) {
                                                                echo    "<tr><td> <input type = submit value = " . "program" . $x . " class = submitbutton></td>
                                                                <td> ". $x . "</td></tr>" ; 
                                                        }
                                                        echo "</table>";
                                                ?>
                        </table>
                </body>
</html>