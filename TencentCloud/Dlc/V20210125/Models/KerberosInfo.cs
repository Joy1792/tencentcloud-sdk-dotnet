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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class KerberosInfo : AbstractModel
    {
        
        /// <summary>
        /// Krb5Conf文件值
        /// </summary>
        [JsonProperty("Krb5Conf")]
        public string Krb5Conf{ get; set; }

        /// <summary>
        /// KeyTab文件值
        /// </summary>
        [JsonProperty("KeyTab")]
        public string KeyTab{ get; set; }

        /// <summary>
        /// 服务主体
        /// </summary>
        [JsonProperty("ServicePrincipal")]
        public string ServicePrincipal{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Krb5Conf", this.Krb5Conf);
            this.SetParamSimple(map, prefix + "KeyTab", this.KeyTab);
            this.SetParamSimple(map, prefix + "ServicePrincipal", this.ServicePrincipal);
        }
    }
}

