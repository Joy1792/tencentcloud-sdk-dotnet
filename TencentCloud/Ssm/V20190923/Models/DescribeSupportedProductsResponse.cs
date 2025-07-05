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

namespace TencentCloud.Ssm.V20190923.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSupportedProductsResponse : AbstractModel
    {
        
        /// <summary>
        /// 支持的所有云产品列表。
        /// 每种云产品与凭据类型的对应关系如下：
        /// 当SecretType为1时，支持的云产品列表包括：Mysql、Tdsql-mysql、Tdsql_C_Mysql；
        /// 当SecretType为2时，支持的产品列表为：Cvm；
        /// 当SecretType为3时，支持的产品列表为：Cam（此功能的使用需要联系云助手单独开始白名单）；
        /// 当SecretType为4时，支持的产品列表为：Redis。
        /// </summary>
        [JsonProperty("Products")]
        public string[] Products{ get; set; }

        /// <summary>
        /// 支持的产品个数
        /// </summary>
        [JsonProperty("TotalCount")]
        public long? TotalCount{ get; set; }

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
            this.SetParamArraySimple(map, prefix + "Products.", this.Products);
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

