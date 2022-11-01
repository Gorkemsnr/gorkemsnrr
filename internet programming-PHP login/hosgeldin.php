<?php
 session_start();
 echo"Hoşgeldiniz ". $_SESSION['kullanici'];
 echo "<a href='cikis.php'>Çıkış</a>";
?>