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

namespace TencentCloud.Cdwdoris.V20211228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDmsSqlHistoryRequest : AbstractModel
    {
        
        /// <summary>
        /// 查询节点ip
        /// </summary>
        [JsonProperty("QueryNode")]
        public string[] QueryNode{ get; set; }

        /// <summary>
        /// 运行状态
        /// </summary>
        [JsonProperty("QueryStatus")]
        public string[] QueryStatus{ get; set; }

        /// <summary>
        /// 模糊搜索sql
        /// </summary>
        [JsonProperty("QuerySql")]
        public string QuerySql{ get; set; }

        /// <summary>
        /// 根据报错原因搜索
        /// </summary>
        [JsonProperty("QueryErrMsg")]
        public string QueryErrMsg{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "QueryNode.", this.QueryNode);
            this.SetParamArraySimple(map, prefix + "QueryStatus.", this.QueryStatus);
            this.SetParamSimple(map, prefix + "QuerySql", this.QuerySql);
            this.SetParamSimple(map, prefix + "QueryErrMsg", this.QueryErrMsg);
        }
    }
}

