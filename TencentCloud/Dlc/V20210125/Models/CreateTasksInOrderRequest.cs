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

    public class CreateTasksInOrderRequest : AbstractModel
    {
        
        /// <summary>
        /// 数据库名称。如果SQL语句中有数据库名称，优先使用SQL语句中的数据库，否则使用该参数指定的数据库。
        /// </summary>
        [JsonProperty("DatabaseName")]
        public string DatabaseName{ get; set; }

        /// <summary>
        /// SQL任务信息
        /// </summary>
        [JsonProperty("Tasks")]
        public TasksInfo Tasks{ get; set; }

        /// <summary>
        /// 数据源名称，默认为COSDataCatalog
        /// </summary>
        [JsonProperty("DatasourceConnectionName")]
        public string DatasourceConnectionName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DatabaseName", this.DatabaseName);
            this.SetParamObj(map, prefix + "Tasks.", this.Tasks);
            this.SetParamSimple(map, prefix + "DatasourceConnectionName", this.DatasourceConnectionName);
        }
    }
}

