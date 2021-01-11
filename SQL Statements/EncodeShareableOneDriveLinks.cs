string sharingUrl = "https://1drv.ms/b/s!AvaHb03-LlJmiEnIyNU270xtjieh";
string base64Value = System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(sharingUrl));
string encodedUrl = "u!" + base64Value.TrimEnd('=').Replace('/','_').Replace('+','-');
writeline(encodedUrl);