var name = "enter name";

var url = "https://api.cloutflare.tech/check?name=" + name;

var httpRequest = (HttpWebRequest)WebRequest.Create(url);


var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
{
   var result = streamReader.ReadToEnd();
}
if(httpResponse.StatusCode == 404) {Console.WriteLine("[TAKEN] " + name);}
else if(httpResponse.StatusCode == 200) {Console.WriteLine("[HIT] " + name);}
else {Console.WriteLine("[ERROR] " + name);};
