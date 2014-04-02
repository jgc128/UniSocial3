﻿using Collector.Common;
using Collector.Interface;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Collector.Api
{
	public abstract class BaseApi : IApi
	{
		IApi api;
		IApiSettingsProvider apiSettingsProvider;

		public BaseApi(IApi Api, IApiSettingsProvider ApiSettingsProvider)
		{
			this.api = Api;
			this.apiSettingsProvider = ApiSettingsProvider;
		}



	}
}