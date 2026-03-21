$client = new-object System.Net.WebClient
$sheetid = "1A9iq7THf-0YI7CyBbjnQPDK96aXtWeoni3Xw6v_9hKk"

$gid = "1992523428"
$sheetname = "data.POKEMON"
$range = "B1:AH"
$client.DownloadFile("https://docs.google.com/spreadsheets/d/$sheetid/export?format=csv&gid=$gid&range=$range", "wwwroot/data/$sheetname.csv")
import-csv "wwwroot/data/$sheetname.csv" | ConvertTo-Json | Set-Content -Path "wwwroot/data/$sheetname.json" -Encoding utf8