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

namespace TencentCloud.Iss.V20230517.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SetForbidPlayChannelsRequest : AbstractModel
    {
        
        /// <summary>
        /// 要禁播的通道参数，一次最多可以设置200个通道
        /// </summary>
        [JsonProperty("Channels")]
        public SetForbidplayChannelParam[] Channels{ get; set; }

        /// <summary>
        /// 用户uin，可以是子用户的也可以是主用户的uin
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Channels.", this.Channels);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
        }
    }
}

