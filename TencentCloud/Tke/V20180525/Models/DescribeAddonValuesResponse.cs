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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAddonValuesResponse : AbstractModel
    {
        
        /// <summary>
        /// 参数列表，如果addon已安装，会使用已设置的参数和chart里的默认参数做渲染，是一个json格式的字符串，未安装addon时返回为空值。
        /// </summary>
        [JsonProperty("Values")]
        public string Values{ get; set; }

        /// <summary>
        /// addon支持的参数列表，值为chart的默认值，是一个json格式的字符串。
        /// </summary>
        [JsonProperty("DefaultValues")]
        public string DefaultValues{ get; set; }

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
            this.SetParamSimple(map, prefix + "Values", this.Values);
            this.SetParamSimple(map, prefix + "DefaultValues", this.DefaultValues);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

