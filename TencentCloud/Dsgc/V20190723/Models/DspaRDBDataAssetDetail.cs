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

namespace TencentCloud.Dsgc.V20190723.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DspaRDBDataAssetDetail : AbstractModel
    {
        
        /// <summary>
        /// 数据源ID
        /// </summary>
        [JsonProperty("DataSourceId")]
        public string DataSourceId{ get; set; }

        /// <summary>
        /// 数据库类型
        /// </summary>
        [JsonProperty("DbType")]
        public string DbType{ get; set; }

        /// <summary>
        /// 数据库名称
        /// </summary>
        [JsonProperty("DbName")]
        public string DbName{ get; set; }

        /// <summary>
        /// 数据库表名称
        /// </summary>
        [JsonProperty("TableName")]
        public string TableName{ get; set; }

        /// <summary>
        /// 数据库表字段名称
        /// </summary>
        [JsonProperty("FieldName")]
        public string FieldName{ get; set; }

        /// <summary>
        /// 规则名称
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// 数据分类
        /// </summary>
        [JsonProperty("CategoryName")]
        public string CategoryName{ get; set; }

        /// <summary>
        /// 敏感等级
        /// </summary>
        [JsonProperty("LevelRiskName")]
        public string LevelRiskName{ get; set; }

        /// <summary>
        /// 分级风险分数，1-10，最小值为1，最大值为10
        /// </summary>
        [JsonProperty("LevelRiskScore")]
        public long? LevelRiskScore{ get; set; }

        /// <summary>
        /// 可信分
        /// </summary>
        [JsonProperty("TrustedScore")]
        public string TrustedScore{ get; set; }

        /// <summary>
        /// 资源所在地域
        /// </summary>
        [JsonProperty("ResourceRegion")]
        public string ResourceRegion{ get; set; }

        /// <summary>
        /// 字段扫描结果ID
        /// </summary>
        [JsonProperty("FieldResultId")]
        public string FieldResultId{ get; set; }

        /// <summary>
        /// 规则ID
        /// </summary>
        [JsonProperty("RuleId")]
        public long? RuleId{ get; set; }

        /// <summary>
        /// 分级ID
        /// </summary>
        [JsonProperty("LevelId")]
        public long? LevelId{ get; set; }

        /// <summary>
        /// 分类ID
        /// </summary>
        [JsonProperty("CategoryId")]
        public long? CategoryId{ get; set; }

        /// <summary>
        /// 数据源名称
        /// </summary>
        [JsonProperty("DataSourceName")]
        public string DataSourceName{ get; set; }

        /// <summary>
        /// 保护措施
        /// </summary>
        [JsonProperty("SafeGuard")]
        public DspaSafeGuard SafeGuard{ get; set; }

        /// <summary>
        /// 分类路径
        /// </summary>
        [JsonProperty("CategoryFullPath")]
        public string CategoryFullPath{ get; set; }

        /// <summary>
        /// 0.系统识别，1人工打标
        /// </summary>
        [JsonProperty("IdentifyType")]
        public long? IdentifyType{ get; set; }

        /// <summary>
        /// 0未核查 1已核查
        /// </summary>
        [JsonProperty("CheckStatus")]
        public long? CheckStatus{ get; set; }

        /// <summary>
        /// 0非敏感，1敏感
        /// </summary>
        [JsonProperty("IsSensitiveData")]
        public long? IsSensitiveData{ get; set; }

        /// <summary>
        /// 模式名
        /// </summary>
        [JsonProperty("SchemaName")]
        public string SchemaName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DataSourceId", this.DataSourceId);
            this.SetParamSimple(map, prefix + "DbType", this.DbType);
            this.SetParamSimple(map, prefix + "DbName", this.DbName);
            this.SetParamSimple(map, prefix + "TableName", this.TableName);
            this.SetParamSimple(map, prefix + "FieldName", this.FieldName);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "CategoryName", this.CategoryName);
            this.SetParamSimple(map, prefix + "LevelRiskName", this.LevelRiskName);
            this.SetParamSimple(map, prefix + "LevelRiskScore", this.LevelRiskScore);
            this.SetParamSimple(map, prefix + "TrustedScore", this.TrustedScore);
            this.SetParamSimple(map, prefix + "ResourceRegion", this.ResourceRegion);
            this.SetParamSimple(map, prefix + "FieldResultId", this.FieldResultId);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "LevelId", this.LevelId);
            this.SetParamSimple(map, prefix + "CategoryId", this.CategoryId);
            this.SetParamSimple(map, prefix + "DataSourceName", this.DataSourceName);
            this.SetParamObj(map, prefix + "SafeGuard.", this.SafeGuard);
            this.SetParamSimple(map, prefix + "CategoryFullPath", this.CategoryFullPath);
            this.SetParamSimple(map, prefix + "IdentifyType", this.IdentifyType);
            this.SetParamSimple(map, prefix + "CheckStatus", this.CheckStatus);
            this.SetParamSimple(map, prefix + "IsSensitiveData", this.IsSensitiveData);
            this.SetParamSimple(map, prefix + "SchemaName", this.SchemaName);
        }
    }
}

