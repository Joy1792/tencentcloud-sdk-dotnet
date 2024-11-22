/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeNetworkInterfaceLimitResponse : AbstractModel
    {
        
        /// <summary>
        /// 标准型弹性网卡配额。
        /// </summary>
        [JsonProperty("EniQuantity")]
        public long? EniQuantity{ get; set; }

        /// <summary>
        /// 每个标准型弹性网卡可以分配的IP配额。
        /// </summary>
        [JsonProperty("EniPrivateIpAddressQuantity")]
        public long? EniPrivateIpAddressQuantity{ get; set; }

        /// <summary>
        /// 扩展型网卡配额。
        /// </summary>
        [JsonProperty("ExtendEniQuantity")]
        public long? ExtendEniQuantity{ get; set; }

        /// <summary>
        /// 每个扩展型弹性网卡可以分配的IP配额。
        /// </summary>
        [JsonProperty("ExtendEniPrivateIpAddressQuantity")]
        public long? ExtendEniPrivateIpAddressQuantity{ get; set; }

        /// <summary>
        /// 中继网卡配额。
        /// </summary>
        [JsonProperty("SubEniQuantity")]
        public long? SubEniQuantity{ get; set; }

        /// <summary>
        /// 每个中继网卡可以分配的IP配额。
        /// </summary>
        [JsonProperty("SubEniPrivateIpAddressQuantity")]
        public long? SubEniPrivateIpAddressQuantity{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EniQuantity", this.EniQuantity);
            this.SetParamSimple(map, prefix + "EniPrivateIpAddressQuantity", this.EniPrivateIpAddressQuantity);
            this.SetParamSimple(map, prefix + "ExtendEniQuantity", this.ExtendEniQuantity);
            this.SetParamSimple(map, prefix + "ExtendEniPrivateIpAddressQuantity", this.ExtendEniPrivateIpAddressQuantity);
            this.SetParamSimple(map, prefix + "SubEniQuantity", this.SubEniQuantity);
            this.SetParamSimple(map, prefix + "SubEniPrivateIpAddressQuantity", this.SubEniPrivateIpAddressQuantity);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

