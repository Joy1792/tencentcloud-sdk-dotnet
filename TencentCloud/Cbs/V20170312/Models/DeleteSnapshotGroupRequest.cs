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

namespace TencentCloud.Cbs.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeleteSnapshotGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// 快照组ID。
        /// </summary>
        [JsonProperty("SnapshotGroupId")]
        public string SnapshotGroupId{ get; set; }

        /// <summary>
        /// 快照组ID 列表。此参数与快照组 ID 至少传 1 个，同时传会与快照组 ID 合并。
        /// </summary>
        [JsonProperty("SnapshotGroupIds")]
        public string[] SnapshotGroupIds{ get; set; }

        /// <summary>
        /// 是否同时删除快照组关联的镜像；取值为false，表示不删除快照组绑定的镜像，此时，如果快照组有绑定的镜像，删除会失败；取值为true，表示同时删除快照组绑定的镜像；默认值为false。
        /// </summary>
        [JsonProperty("DeleteBindImages")]
        public bool? DeleteBindImages{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SnapshotGroupId", this.SnapshotGroupId);
            this.SetParamArraySimple(map, prefix + "SnapshotGroupIds.", this.SnapshotGroupIds);
            this.SetParamSimple(map, prefix + "DeleteBindImages", this.DeleteBindImages);
        }
    }
}

