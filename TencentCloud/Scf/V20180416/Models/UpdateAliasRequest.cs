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

namespace TencentCloud.Scf.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateAliasRequest : AbstractModel
    {
        
        /// <summary>
        /// 函数名称
        /// </summary>
        [JsonProperty("FunctionName")]
        public string FunctionName{ get; set; }

        /// <summary>
        /// 别名的名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 别名指向的主版本
        /// </summary>
        [JsonProperty("FunctionVersion")]
        public string FunctionVersion{ get; set; }

        /// <summary>
        /// 函数所在的命名空间
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// 别名的路由信息，需要为别名指定附加版本时，必须提供此参数；	  附加版本指的是：除主版本 FunctionVersion 外，为此别名再指定一个函数可正常使用的版本；   这里附加版本中的 Version 值 不能是别名指向的主版本；  要注意的是：如果想要某个版本的流量全部指向这个别名，不需配置此参数； 目前一个别名最多只能指定一个附加版本
        /// </summary>
        [JsonProperty("RoutingConfig")]
        public RoutingConfig RoutingConfig{ get; set; }

        /// <summary>
        /// 别名的描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FunctionName", this.FunctionName);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "FunctionVersion", this.FunctionVersion);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamObj(map, prefix + "RoutingConfig.", this.RoutingConfig);
            this.SetParamSimple(map, prefix + "Description", this.Description);
        }
    }
}

