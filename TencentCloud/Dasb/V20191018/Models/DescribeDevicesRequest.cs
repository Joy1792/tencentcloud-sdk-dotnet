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

namespace TencentCloud.Dasb.V20191018.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDevicesRequest : AbstractModel
    {
        
        /// <summary>
        /// 资产ID集合
        /// </summary>
        [JsonProperty("IdSet")]
        public ulong?[] IdSet{ get; set; }

        /// <summary>
        /// 资产名或资产IP，模糊查询
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 暂未使用
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }

        /// <summary>
        /// 地域码集合
        /// </summary>
        [JsonProperty("ApCodeSet")]
        public string[] ApCodeSet{ get; set; }

        /// <summary>
        /// 操作系统类型, 1 - Linux, 2 - Windows, 3 - MySQL, 4 - SQLServer, 5 - TDSQL MySQL, 6 - TDSQL-C MySQL, 7 - MariaDB, 8 - PostgreSQL, 9 - MongoDB副本集群, 10 - MongoDB分片集群, 11 - Redis
        /// </summary>
        [JsonProperty("Kind")]
        public ulong? Kind{ get; set; }

        /// <summary>
        /// 分页偏移位置，默认值为0
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 每页条目数量，默认20
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 有该资产访问权限的用户ID集合
        /// </summary>
        [JsonProperty("AuthorizedUserIdSet")]
        public ulong?[] AuthorizedUserIdSet{ get; set; }

        /// <summary>
        /// 过滤条件，资产绑定的堡垒机服务ID集合
        /// </summary>
        [JsonProperty("ResourceIdSet")]
        public string[] ResourceIdSet{ get; set; }

        /// <summary>
        /// 可提供按照多种类型过滤, 取值范围与Kind一致
        /// </summary>
        [JsonProperty("KindSet")]
        public ulong?[] KindSet{ get; set; }

        /// <summary>
        /// 资产是否包含托管账号。1，包含；0，不包含
        /// </summary>
        [JsonProperty("ManagedAccount")]
        public string ManagedAccount{ get; set; }

        /// <summary>
        /// 过滤条件，可按照部门ID进行过滤
        /// </summary>
        [JsonProperty("DepartmentId")]
        public string DepartmentId{ get; set; }

        /// <summary>
        /// 过滤条件，可按照标签键、标签进行过滤。如果同时指定标签键和标签过滤条件，它们之间为“AND”的关系
        /// </summary>
        [JsonProperty("TagFilters")]
        public TagFilter[] TagFilters{ get; set; }

        /// <summary>
        /// 过滤数组。支持的Name：
        /// BindingStatus 绑定状态
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "IdSet.", this.IdSet);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Ip", this.Ip);
            this.SetParamArraySimple(map, prefix + "ApCodeSet.", this.ApCodeSet);
            this.SetParamSimple(map, prefix + "Kind", this.Kind);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArraySimple(map, prefix + "AuthorizedUserIdSet.", this.AuthorizedUserIdSet);
            this.SetParamArraySimple(map, prefix + "ResourceIdSet.", this.ResourceIdSet);
            this.SetParamArraySimple(map, prefix + "KindSet.", this.KindSet);
            this.SetParamSimple(map, prefix + "ManagedAccount", this.ManagedAccount);
            this.SetParamSimple(map, prefix + "DepartmentId", this.DepartmentId);
            this.SetParamArrayObj(map, prefix + "TagFilters.", this.TagFilters);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

