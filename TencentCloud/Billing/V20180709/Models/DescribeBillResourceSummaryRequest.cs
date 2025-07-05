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

namespace TencentCloud.Billing.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeBillResourceSummaryRequest : AbstractModel
    {
        
        /// <summary>
        /// 分页偏移量，Offset=0表示第一页，如果Limit=100，则Offset=100表示第二页，Offset=200表示第三页，依次类推
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 数量，最大值为1000
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 月份，格式为yyyy-mm。不能早于开通账单2.0的月份
        /// </summary>
        [JsonProperty("Month")]
        public string Month{ get; set; }

        /// <summary>
        /// 周期类型，byUsedTime按计费周期/byPayTime按扣费周期。需要与费用中心该月份账单的周期保持一致。您可前往[账单概览](https://console.cloud.tencent.com/expense/bill/overview)页面顶部查看确认您的账单统计周期类型。
        /// </summary>
        [JsonProperty("PeriodType")]
        [System.Obsolete]
        public string PeriodType{ get; set; }

        /// <summary>
        /// 是否需要访问列表的总记录数，用于前端分页
        /// 1-表示需要， 0-表示不需要
        /// </summary>
        [JsonProperty("NeedRecordNum")]
        public long? NeedRecordNum{ get; set; }

        /// <summary>
        /// 查询交易类型（请使用交易类型名称入参），入参示例枚举如下：
        /// 包年包月新购
        /// 包年包月续费
        /// 包年包月配置变更
        /// 包年包月退款 
        /// 按量计费扣费 
        /// 线下项目扣费 
        /// 线下产品扣费 
        /// 调账扣费 
        /// 调账补偿 
        /// 按量计费小时结 
        /// 按量计费日结 
        /// 按量计费月结 
        /// 竞价实例小时结 
        /// 线下项目调账补偿 
        /// 线下产品调账补偿 
        /// 优惠扣费 
        /// 优惠补偿 
        /// 按量计费迁入资源 
        /// 按量计费迁出资源 
        /// 包年包月迁入资源 
        /// 包年包月迁出资源 
        /// 预付费用 
        /// 小时费用 
        /// 预留实例退款 
        /// 按量计费冲正 
        /// 包年包月转按量 
        /// 保底扣款 
        /// 节省计划小时费用
        /// </summary>
        [JsonProperty("ActionType")]
        public string ActionType{ get; set; }

        /// <summary>
        /// 查询指定资源信息
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// 付费模式 prePay/postPay
        /// </summary>
        [JsonProperty("PayMode")]
        public string PayMode{ get; set; }

        /// <summary>
        /// 产品名称代码
        /// 备注：如需获取当月使用过的BusinessCode，请调用API：<a href="https://cloud.tencent.com/document/product/555/35761">获取产品汇总费用分布</a>
        /// </summary>
        [JsonProperty("BusinessCode")]
        public string BusinessCode{ get; set; }

        /// <summary>
        /// 支付者的账号 ID（账号 ID 是用户在腾讯云的唯一账号标识），默认查询本账号账单，如集团管理账号需查询成员账号自付的账单，该字段需入参成员账号UIN
        /// </summary>
        [JsonProperty("PayerUin")]
        public string PayerUin{ get; set; }

        /// <summary>
        /// 分账标签键，用户自定义（支持2021-01以后账单查询）
        /// </summary>
        [JsonProperty("TagKey")]
        public string TagKey{ get; set; }

        /// <summary>
        /// 分账标签值，该参数为空表示该标签键下未设置标签值的记录
        /// （支持2021-01以后账单查询）
        /// </summary>
        [JsonProperty("TagValue")]
        public string TagValue{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Month", this.Month);
            this.SetParamSimple(map, prefix + "PeriodType", this.PeriodType);
            this.SetParamSimple(map, prefix + "NeedRecordNum", this.NeedRecordNum);
            this.SetParamSimple(map, prefix + "ActionType", this.ActionType);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "BusinessCode", this.BusinessCode);
            this.SetParamSimple(map, prefix + "PayerUin", this.PayerUin);
            this.SetParamSimple(map, prefix + "TagKey", this.TagKey);
            this.SetParamSimple(map, prefix + "TagValue", this.TagValue);
        }
    }
}

