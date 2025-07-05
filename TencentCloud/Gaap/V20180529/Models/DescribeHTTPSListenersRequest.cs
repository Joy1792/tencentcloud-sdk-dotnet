/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Gaap.V20180529.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeHTTPSListenersRequest : AbstractModel
    {
        
        /// <summary>
        /// 通道ID。ListenerId、ProxyId、GroupId须至少填写一个，且ProxyId与GroupId至多只能填写其中一个。
        /// </summary>
        [JsonProperty("ProxyId")]
        public string ProxyId{ get; set; }

        /// <summary>
        /// 通道组ID。ListenerId、ProxyId、GroupId须至少填写一个，且ProxyId与GroupId至多只能填写其中一个。
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// 过滤条件，根据监听器ID进行精确查询。ListenerId、ProxyId、GroupId须至少填写一个，且ProxyId与GroupId至多只能填写其中一个。
        /// </summary>
        [JsonProperty("ListenerId")]
        public string ListenerId{ get; set; }

        /// <summary>
        /// 过滤条件，根据监听器名称进行精确查询。
        /// </summary>
        [JsonProperty("ListenerName")]
        public string ListenerName{ get; set; }

        /// <summary>
        /// 过滤条件，根据监听器端口进行精确查询。
        /// </summary>
        [JsonProperty("Port")]
        public ulong? Port{ get; set; }

        /// <summary>
        /// 偏移量， 默认为0
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 限制数量，默认为20
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 过滤条件，支持按照端口或监听器名称进行模糊查询
        /// </summary>
        [JsonProperty("SearchValue")]
        public string SearchValue{ get; set; }

        /// <summary>
        /// 支持Http3的开关，其中：
        /// 0，表示不需要支持Http3接入；
        /// 1，表示需要支持Http3接入。
        /// 注意：如果支持了Http3的功能，那么该监听器会占用对应的UDP接入端口，不可再创建相同端口的UDP监听器。
        /// 该功能的启停无法在监听器创建完毕后再修改。
        /// </summary>
        [JsonProperty("Http3Supported")]
        public long? Http3Supported{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProxyId", this.ProxyId);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "ListenerId", this.ListenerId);
            this.SetParamSimple(map, prefix + "ListenerName", this.ListenerName);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "SearchValue", this.SearchValue);
            this.SetParamSimple(map, prefix + "Http3Supported", this.Http3Supported);
        }
    }
}

