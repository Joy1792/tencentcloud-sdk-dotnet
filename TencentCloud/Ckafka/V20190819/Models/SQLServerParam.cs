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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SQLServerParam : AbstractModel
    {
        
        /// <summary>
        /// SQLServer的数据库名称
        /// </summary>
        [JsonProperty("Database")]
        public string Database{ get; set; }

        /// <summary>
        /// SQLServer的数据表名称，"*"为所监听的所有数据库中的非系统表，可以","间隔，监听多个数据表，但数据表需要以"数据库名.数据表名"的格式进行填写
        /// </summary>
        [JsonProperty("Table")]
        public string Table{ get; set; }

        /// <summary>
        /// 该SQLServer在连接管理内的Id
        /// </summary>
        [JsonProperty("Resource")]
        public string Resource{ get; set; }

        /// <summary>
        /// 复制存量信息(schema_only增量, initial全量)，默认为initial
        /// </summary>
        [JsonProperty("SnapshotMode")]
        public string SnapshotMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Database", this.Database);
            this.SetParamSimple(map, prefix + "Table", this.Table);
            this.SetParamSimple(map, prefix + "Resource", this.Resource);
            this.SetParamSimple(map, prefix + "SnapshotMode", this.SnapshotMode);
        }
    }
}

