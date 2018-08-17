<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
<form>
    N: <input type="text" name="num"/>
    <input type="submit"/>
</form>
<?php
if (isset($_GET['num'])) {
    $num = intval($_GET['num']);
    if ($num == 1) {
        echo 1;
    } elseif ($num == 2) {
        echo "1 1";
    } else {
        echo "1 1 ";
        $num1 = 1;
        $num2 = 1;
        for ($i = 2; $i < $num; $i++) {
            $num3 = $num1 + $num2;
            $num1 = $num2;
            $num2 = $num3;
            echo "$num3 ";
        }
    }
}
?>
</body>
</html>