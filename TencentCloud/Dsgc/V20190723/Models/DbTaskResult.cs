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

namespace TencentCloud.Dsgc.V20190723.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DbTaskResult : AbstractModel
    {
        
        /// <summary>
        /// 结果类型。
        /// </summary>
        [JsonProperty("Result")]
        public string Result{ get; set; }

        /// <summary>
        /// 结果描述。
        /// </summary>
        [JsonProperty("ResultDescription")]
        public string ResultDescription{ get; set; }

        /// <summary>
        /// 错误信息描述。
        /// </summary>
        [JsonProperty("ErrDescription")]
        public ErrDescription ErrDescription{ get; set; }

        /// <summary>
        /// 资源ID。
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// database名称。
        /// </summary>
        [JsonProperty("DbName")]
        public string DbName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Result", this.Result);
            this.SetParamSimple(map, prefix + "ResultDescription", this.ResultDescription);
            this.SetParamObj(map, prefix + "ErrDescription.", this.ErrDescription);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "DbName", this.DbName);
        }
    }
}

