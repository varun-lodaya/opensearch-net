/* SPDX-License-Identifier: Apache-2.0
*
* The OpenSearch Contributors require contributions made to
* this file be licensed under the Apache-2.0 license or a
* compatible open source license.
*
* Modifications Copyright OpenSearch Contributors. See
* GitHub history for details.
*
*  Licensed to Elasticsearch B.V. under one or more contributor
*  license agreements. See the NOTICE file distributed with
*  this work for additional information regarding copyright
*  ownership. Elasticsearch B.V. licenses this file to you under
*  the Apache License, Version 2.0 (the "License"); you may
*  not use this file except in compliance with the License.
*  You may obtain a copy of the License at
*
* 	http://www.apache.org/licenses/LICENSE-2.0
*
*  Unless required by applicable law or agreed to in writing,
*  software distributed under the License is distributed on an
*  "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
*  KIND, either express or implied.  See the License for the
*  specific language governing permissions and limitations
*  under the License.
*/
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗  
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝  
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// -----------------------------------------------
//  
// This file is automatically generated 
// Please do not edit these files manually
// Run the following in the root of the repos:
//
// 		*NIX 		:	./build.sh codegen
// 		Windows 	:	build.bat codegen
//
// -----------------------------------------------
// ReSharper disable RedundantUsingDirective
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

// ReSharper disable once CheckNamespace
namespace OpenSearch.Net.Specification.IngestApi
{
	///<summary>Request options for DeletePipeline <para></para></summary>
	public class DeletePipelineRequestParameters : RequestParameters<DeletePipelineRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.DELETE;
		public override bool SupportsBody => false;
		///<summary>Explicit operation timeout for connection to master node</summary>
		public TimeSpan MasterTimeout
		{
			get => Q<TimeSpan>("master_timeout");
			set => Q("master_timeout", value);
		}

		///<summary>Explicit operation timeout</summary>
		public TimeSpan Timeout
		{
			get => Q<TimeSpan>("timeout");
			set => Q("timeout", value);
		}
	}

	///<summary>Request options for GetPipeline <para></para></summary>
	public class GetPipelineRequestParameters : RequestParameters<GetPipelineRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.GET;
		public override bool SupportsBody => false;
		///<summary>Explicit operation timeout for connection to master node</summary>
		public TimeSpan MasterTimeout
		{
			get => Q<TimeSpan>("master_timeout");
			set => Q("master_timeout", value);
		}
	}

	///<summary>Request options for GrokProcessorPatterns <para></para></summary>
	public class GrokProcessorPatternsRequestParameters : RequestParameters<GrokProcessorPatternsRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.GET;
		public override bool SupportsBody => false;
	}

	///<summary>Request options for PutPipeline <para></para></summary>
	public class PutPipelineRequestParameters : RequestParameters<PutPipelineRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.PUT;
		public override bool SupportsBody => true;
		///<summary>Explicit operation timeout for connection to master node</summary>
		public TimeSpan MasterTimeout
		{
			get => Q<TimeSpan>("master_timeout");
			set => Q("master_timeout", value);
		}

		///<summary>Explicit operation timeout</summary>
		public TimeSpan Timeout
		{
			get => Q<TimeSpan>("timeout");
			set => Q("timeout", value);
		}
	}

	///<summary>Request options for SimulatePipeline <para></para></summary>
	public class SimulatePipelineRequestParameters : RequestParameters<SimulatePipelineRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
		public override bool SupportsBody => true;
		///<summary>Verbose mode. Display data output for each processor in executed pipeline</summary>
		public bool? Verbose
		{
			get => Q<bool? >("verbose");
			set => Q("verbose", value);
		}
	}
}
