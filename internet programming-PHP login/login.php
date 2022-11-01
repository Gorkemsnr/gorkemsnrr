<html>
<head><meta charset="utf-8"/></head>
<title>Login</title>
<body>
<table cellpadding="5" cellspacing="10" align="center">
<form method="post" action="dogrulama.php">
	<tr><th>kullanici:<input type="text" name="kullanici"/></br></td></tr>
	<tr><th>sifre:<input type="password" name="sifre"/></br></td></tr>
	<tr><th>beni hatırla:<input type="checkbox" name"hatırla" value="1" /></br></th>
	<tr><td colspan="2" align="right"><input type="submit" value="giris" name="login"/></br></td></tr>
<?php
		echo "Ziyaretci sayfalarını gezmek için <a href='ziyaretci.php'>tıklayın</a>"
?>
</form>
</table>
</body>
</html>