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

    public class ModifyDisksChargeTypeRequest : AbstractModel
    {
        
        /// <summary>
        /// 一个或多个待操作的云硬盘ID,可以通过[DescribeDisks](/document/product/362/16315)接口查询。每次请求批量云硬盘上限为100。
        /// </summary>
        [JsonProperty("DiskIds")]
        public string[] DiskIds{ get; set; }

        /// <summary>
        /// 设置为预付费模式，即包年包月相关参数设置。通过该参数可以指定包年包月实例的购买时长、是否设置自动续费等属性。
        /// </summary>
        [JsonProperty("DiskChargePrepaid")]
        public DiskChargePrepaid DiskChargePrepaid{ get; set; }

        /// <summary>
        /// 设置为后付费模式
        /// </summary>
        [JsonProperty("DiskChargePostpaid")]
        public bool? DiskChargePostpaid{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "DiskIds.", this.DiskIds);
            this.SetParamObj(map, prefix + "DiskChargePrepaid.", this.DiskChargePrepaid);
            this.SetParamSimple(map, prefix + "DiskChargePostpaid", this.DiskChargePostpaid);
        }
    }
}

