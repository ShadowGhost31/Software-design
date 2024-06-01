using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using ForTest.ForTest;

namespace ForTest
{
	internal class SingleWordRequester : IWordRequester
	{
		public async Task<string> GetRandomWordAsync()
		{
			HttpResponseMessage response = await HttpClientSingleton.Instance.GetAsync("https://random-word-api.herokuapp.com/word");
			response.EnsureSuccessStatusCode();

			string jsonResponse = await response.Content.ReadAsStringAsync();
			return jsonResponse.Split('"')[1];
		}
	}
}
