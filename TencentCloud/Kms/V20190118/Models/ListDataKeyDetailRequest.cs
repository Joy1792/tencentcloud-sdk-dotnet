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

namespace TencentCloud.Kms.V20190118.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ListDataKeyDetailRequest : AbstractModel
    {
        
        /// <summary>
        /// 含义跟 SQL 查询的 Offset 一致，表示本次获取从按一定顺序排列数组的第 Offset 个元素开始，缺省为0
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 含义跟 SQL 查询的 Limit 一致，表示本次最多获取 Limit 个元素。缺省值为10，最大值为200
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 根据创建者角色筛选，默认 0 表示用户自己创建的数据密钥， 1 表示授权其它云产品自动创建的数据密钥
        /// </summary>
        [JsonProperty("Role")]
        public ulong? Role{ get; set; }

        /// <summary>
        /// 根据DataKey创建时间排序， 0 表示按照降序排序，1表示按照升序排序
        /// </summary>
        [JsonProperty("OrderType")]
        public ulong? OrderType{ get; set; }

        /// <summary>
        /// 根据DataKey状态筛选， 0表示全部DataKey， 1 表示仅查询Enabled DataKey， 2 表示仅查询Disabled DataKey，3 表示查询PendingDelete 状态的DataKey(处于计划删除状态的Key)。
        /// </summary>
        [JsonProperty("KeyState")]
        public ulong? KeyState{ get; set; }

        /// <summary>
        /// 根据DataKeyId或者DataKeyName进行模糊匹配查询
        /// </summary>
        [JsonProperty("SearchKeyAlias")]
        public string SearchKeyAlias{ get; set; }

        /// <summary>
        /// 根据DateKey类型筛选， "TENCENT_KMS" 表示筛选密钥材料由KMS创建的数据密钥， "EXTERNAL" 表示筛选密钥材料需要用户导入的 EXTERNAL类型数据密钥，"ALL" 或者不设置表示两种类型都查询，大小写敏感。
        /// </summary>
        [JsonProperty("Origin")]
        public string Origin{ get; set; }

        /// <summary>
        /// KMS 高级版对应的 HSM 集群 ID。
        /// </summary>
        [JsonProperty("HsmClusterId")]
        public string HsmClusterId{ get; set; }

        /// <summary>
        /// 根密钥全局唯一标识符
        /// </summary>
        [JsonProperty("KeyId")]
        public string KeyId{ get; set; }

        /// <summary>
        /// 数据密钥的长度
        /// </summary>
        [JsonProperty("DataKeyLen")]
        public ulong? DataKeyLen{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Role", this.Role);
            this.SetParamSimple(map, prefix + "OrderType", this.OrderType);
            this.SetParamSimple(map, prefix + "KeyState", this.KeyState);
            this.SetParamSimple(map, prefix + "SearchKeyAlias", this.SearchKeyAlias);
            this.SetParamSimple(map, prefix + "Origin", this.Origin);
            this.SetParamSimple(map, prefix + "HsmClusterId", this.HsmClusterId);
            this.SetParamSimple(map, prefix + "KeyId", this.KeyId);
            this.SetParamSimple(map, prefix + "DataKeyLen", this.DataKeyLen);
        }
    }
}

