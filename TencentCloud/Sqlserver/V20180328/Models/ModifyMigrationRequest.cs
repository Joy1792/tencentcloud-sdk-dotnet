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

namespace TencentCloud.Sqlserver.V20180328.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyMigrationRequest : AbstractModel
    {
        
        /// <summary>
        /// 迁移任务ID
        /// </summary>
        [JsonProperty("MigrateId")]
        public ulong? MigrateId{ get; set; }

        /// <summary>
        /// 新的迁移任务的名称，若不填则不修改
        /// </summary>
        [JsonProperty("MigrateName")]
        public string MigrateName{ get; set; }

        /// <summary>
        /// 新的迁移类型（1:结构迁移 2:数据迁移 3:增量同步），若不填则不修改
        /// </summary>
        [JsonProperty("MigrateType")]
        public ulong? MigrateType{ get; set; }

        /// <summary>
        /// 迁移源的类型 1:TencentDB for SQLServer 2:云服务器自建SQLServer数据库 4:SQLServer备份还原 5:SQLServer备份还原（COS方式），若不填则不修改
        /// </summary>
        [JsonProperty("SourceType")]
        public ulong? SourceType{ get; set; }

        /// <summary>
        /// 迁移源，若不填则不修改
        /// </summary>
        [JsonProperty("Source")]
        public MigrateSource Source{ get; set; }

        /// <summary>
        /// 迁移目标，若不填则不修改
        /// </summary>
        [JsonProperty("Target")]
        public MigrateTarget Target{ get; set; }

        /// <summary>
        /// 迁移DB对象 ，离线迁移（SourceType=4或SourceType=5）不使用，若不填则不修改
        /// </summary>
        [JsonProperty("MigrateDBSet")]
        public MigrateDB[] MigrateDBSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MigrateId", this.MigrateId);
            this.SetParamSimple(map, prefix + "MigrateName", this.MigrateName);
            this.SetParamSimple(map, prefix + "MigrateType", this.MigrateType);
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
            this.SetParamObj(map, prefix + "Source.", this.Source);
            this.SetParamObj(map, prefix + "Target.", this.Target);
            this.SetParamArrayObj(map, prefix + "MigrateDBSet.", this.MigrateDBSet);
        }
    }
}

