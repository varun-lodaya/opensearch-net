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

using System;
using OpenSearch.Net;
using Osc;
using Tests.Core.ManagedElasticsearch.Clusters;
using Tests.Framework.EndpointTests;
using Tests.Framework.EndpointTests.TestState;

namespace Tests.Indices.Monitoring.IndicesRecovery
{
	public class RecoveryStatusApiTests
		: ApiIntegrationTestBase<ReadOnlyCluster, RecoveryStatusResponse, IRecoveryStatusRequest, RecoveryStatusDescriptor, RecoveryStatusRequest>
	{
		public RecoveryStatusApiTests(ReadOnlyCluster cluster, EndpointUsage usage) : base(cluster, usage) { }

		protected override bool ExpectIsValid => true;
		protected override int ExpectStatusCode => 200;

		protected override Func<RecoveryStatusDescriptor, IRecoveryStatusRequest> Fluent => d => d;
		protected override HttpMethod HttpMethod => HttpMethod.GET;

		protected override RecoveryStatusRequest Initializer => new RecoveryStatusRequest(Infer.AllIndices);
		protected override string UrlPath => "/_all/_recovery";

		protected override LazyResponses ClientUsage() => Calls(
			(client, f) => client.Indices.RecoveryStatus(Infer.AllIndices, f),
			(client, f) => client.Indices.RecoveryStatusAsync(Infer.AllIndices, f),
			(client, r) => client.Indices.RecoveryStatus(r),
			(client, r) => client.Indices.RecoveryStatusAsync(r)
		);
	}
}
