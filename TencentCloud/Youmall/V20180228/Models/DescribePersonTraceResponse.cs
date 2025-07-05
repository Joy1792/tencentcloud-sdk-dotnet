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

namespace TencentCloud.Youmall.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribePersonTraceResponse : AbstractModel
    {
        
        /// <summary>
        /// 卖场系统编码
        /// </summary>
        [JsonProperty("MallId")]
        public string MallId{ get; set; }

        /// <summary>
        /// 卖场用户编码
        /// </summary>
        [JsonProperty("MallCode")]
        public string MallCode{ get; set; }

        /// <summary>
        /// 客户编码
        /// </summary>
        [JsonProperty("PersonId")]
        public string PersonId{ get; set; }

        /// <summary>
        /// 轨迹列表
        /// </summary>
        [JsonProperty("TraceRouteSet")]
        public PersonTraceRoute[] TraceRouteSet{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MallId", this.MallId);
            this.SetParamSimple(map, prefix + "MallCode", this.MallCode);
            this.SetParamSimple(map, prefix + "PersonId", this.PersonId);
            this.SetParamArrayObj(map, prefix + "TraceRouteSet.", this.TraceRouteSet);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

