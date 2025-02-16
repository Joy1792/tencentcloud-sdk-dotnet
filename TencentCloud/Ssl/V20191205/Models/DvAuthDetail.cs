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

namespace TencentCloud.Ssl.V20191205.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DvAuthDetail : AbstractModel
    {
        
        /// <summary>
        /// 证书域名验证记录Key
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DvAuthKey")]
        public string DvAuthKey{ get; set; }

        /// <summary>
        /// 证书域名验证记录值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DvAuthValue")]
        public string DvAuthValue{ get; set; }

        /// <summary>
        /// 证书域名验证域名值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DvAuthDomain")]
        public string DvAuthDomain{ get; set; }

        /// <summary>
        /// 证书域名验证文件路径， 仅FILE、FILE_PROXY使用
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DvAuthPath")]
        public string DvAuthPath{ get; set; }

        /// <summary>
        /// 证书域名验证子域名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DvAuthKeySubDomain")]
        public string DvAuthKeySubDomain{ get; set; }

        /// <summary>
        /// 证书域名验证信息， 存在多个域名验证使用本字段
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DvAuths")]
        public DvAuths[] DvAuths{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DvAuthKey", this.DvAuthKey);
            this.SetParamSimple(map, prefix + "DvAuthValue", this.DvAuthValue);
            this.SetParamSimple(map, prefix + "DvAuthDomain", this.DvAuthDomain);
            this.SetParamSimple(map, prefix + "DvAuthPath", this.DvAuthPath);
            this.SetParamSimple(map, prefix + "DvAuthKeySubDomain", this.DvAuthKeySubDomain);
            this.SetParamArrayObj(map, prefix + "DvAuths.", this.DvAuths);
        }
    }
}

