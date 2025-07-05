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

namespace TencentCloud.Oceanus.V20190422.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ResourceItem : AbstractModel
    {
        
        /// <summary>
        /// 资源ID
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// 资源名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 资源类型
        /// </summary>
        [JsonProperty("ResourceType")]
        public ulong? ResourceType{ get; set; }

        /// <summary>
        /// 资源位置
        /// </summary>
        [JsonProperty("ResourceLoc")]
        public ResourceLoc ResourceLoc{ get; set; }

        /// <summary>
        /// 资源地域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 应用ID
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// 主账号Uin
        /// </summary>
        [JsonProperty("OwnerUin")]
        public string OwnerUin{ get; set; }

        /// <summary>
        /// 子账号Uin
        /// </summary>
        [JsonProperty("CreatorUin")]
        public string CreatorUin{ get; set; }

        /// <summary>
        /// 资源创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 资源最后更新时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 资源的资源版本ID
        /// </summary>
        [JsonProperty("LatestResourceConfigVersion")]
        public long? LatestResourceConfigVersion{ get; set; }

        /// <summary>
        /// 资源备注
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 版本个数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VersionCount")]
        public long? VersionCount{ get; set; }

        /// <summary>
        /// 关联作业数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RefJobCount")]
        public long? RefJobCount{ get; set; }

        /// <summary>
        /// 作业运行状态
        /// </summary>
        [JsonProperty("IsJobRun")]
        public long? IsJobRun{ get; set; }

        /// <summary>
        /// 文件名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// 工作空间ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WorkSpaceId")]
        public long? WorkSpaceId{ get; set; }

        /// <summary>
        /// 分状态统计关联作业数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RefJobStatusCountSet")]
        public RefJobStatusCountItem[] RefJobStatusCountSet{ get; set; }

        /// <summary>
        /// 连接器名称
        /// </summary>
        [JsonProperty("Connector")]
        public string Connector{ get; set; }

        /// <summary>
        /// 连接器版本
        /// </summary>
        [JsonProperty("ConnectorVersion")]
        public string ConnectorVersion{ get; set; }

        /// <summary>
        /// 连接方式
        /// </summary>
        [JsonProperty("ConnectionMethod")]
        public string ConnectionMethod{ get; set; }

        /// <summary>
        /// connector关联的资源id
        /// </summary>
        [JsonProperty("RelatedResourceId")]
        public string RelatedResourceId{ get; set; }

        /// <summary>
        /// 图标
        /// </summary>
        [JsonProperty("Icon")]
        public string Icon{ get; set; }

        /// <summary>
        /// 连接器中文名
        /// </summary>
        [JsonProperty("ConnectorName")]
        public string ConnectorName{ get; set; }

        /// <summary>
        /// 连接器官网链接
        /// </summary>
        [JsonProperty("ConnectorUrl")]
        public string ConnectorUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ResourceType", this.ResourceType);
            this.SetParamObj(map, prefix + "ResourceLoc.", this.ResourceLoc);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "OwnerUin", this.OwnerUin);
            this.SetParamSimple(map, prefix + "CreatorUin", this.CreatorUin);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "LatestResourceConfigVersion", this.LatestResourceConfigVersion);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "VersionCount", this.VersionCount);
            this.SetParamSimple(map, prefix + "RefJobCount", this.RefJobCount);
            this.SetParamSimple(map, prefix + "IsJobRun", this.IsJobRun);
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "WorkSpaceId", this.WorkSpaceId);
            this.SetParamArrayObj(map, prefix + "RefJobStatusCountSet.", this.RefJobStatusCountSet);
            this.SetParamSimple(map, prefix + "Connector", this.Connector);
            this.SetParamSimple(map, prefix + "ConnectorVersion", this.ConnectorVersion);
            this.SetParamSimple(map, prefix + "ConnectionMethod", this.ConnectionMethod);
            this.SetParamSimple(map, prefix + "RelatedResourceId", this.RelatedResourceId);
            this.SetParamSimple(map, prefix + "Icon", this.Icon);
            this.SetParamSimple(map, prefix + "ConnectorName", this.ConnectorName);
            this.SetParamSimple(map, prefix + "ConnectorUrl", this.ConnectorUrl);
        }
    }
}

