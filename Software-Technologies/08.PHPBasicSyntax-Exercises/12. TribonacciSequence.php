<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
<form>
    N: <input type="text" name="num" />
    <input type="submit" />
</form>
<?php
if (isset($_GET['num'])){
    $num = intval($_GET['num']);
    if ($num == 1){
        echo 1;
    } elseif ($num == 2){
        echo "1 1";
    } elseif ($num == 3){
        echo "1 1 2";
    } else{
        echo "1 1 2 ";
        $num1 = 1;
        $num2 = 1;
        $num3 = 2;
        for ($i = 3; $i < $num; $i++){
            $num4 = $num1 + $num2 + $num3;
            $num1 = $num2;
            $num2 = $num3;
            $num3 = $num4;
            echo "$num4 ";
        }
    }
}
?>
</body>
</html>