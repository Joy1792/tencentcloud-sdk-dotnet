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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCDNStatDetailsRequest : AbstractModel
    {
        
        /// <summary>
        /// 查询指标，取值有：
        /// <li>Traffic：流量，单位为 Byte。</li>
        /// <li>Bandwidth：带宽，单位为 Bps。</li>
        /// <li>Requests：请求数。</li>
        /// <li>QUICRequests：QUIC 请求数。</li>
        /// <li>IpVisit：IP 访问数。</li>
        /// </summary>
        [JsonProperty("Metric")]
        public string Metric{ get; set; }

        /// <summary>
        /// 起始时间，使用 [ISO 日期格式](https://cloud.tencent.com/document/product/266/11732#I)。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 结束时间，使用 [ISO 日期格式](https://cloud.tencent.com/document/product/266/11732#I)。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <b>点播[应用](/document/product/266/14574) ID。从2023年12月25日起开通点播的客户，如访问点播应用中的资源（无论是默认应用还是新创建的应用），必须将该字段填写为应用 ID。</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// 域名列表。一次最多查询20个域名的数据。默认返回所有域名叠加的用量数据。
        /// </summary>
        [JsonProperty("DomainNames")]
        public string[] DomainNames{ get; set; }

        /// <summary>
        /// 服务区域，取值有：
        /// <li>Chinese Mainland：中国大陆。 </li>
        /// <li>Asia Pacific Region 1：亚太一区，包括中国香港、中国澳门、新加坡、越南、泰国。 </li>
        /// <li>Asia Pacific Region 2：亚太二区，包括中国台湾、日本、马来西亚、印度尼西亚、韩国。 </li>
        /// <li>Asia Pacific Region 3：亚太三区，包括菲律宾、印度、澳大利亚和亚太其它国家和地区。 </li>
        /// <li>Middle East：中东。 </li>
        /// <li>Europe：欧洲。</li>
        /// <li>North America：北美。</li>
        /// <li>South America：南美。</li>
        /// <li>Africa：非洲。</li>
        /// 默认为中国大陆。
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// 用户所在地区，Area 为 Chinese Mainland 时，取值为以下地区信息，当 Area 为其它值时， 忽略 Districts 参数。
        /// <li>Beijing：北京。</li>
        /// <li>Inner Mongolia：内蒙古。</li>
        /// <li>Shanxi：山西。</li>
        /// <li>Hebei：河北。</li>
        /// <li>Tianjin：天津。</li>
        /// <li>Ningxia：宁夏。</li>
        /// <li>Shaanxi：陕西。</li>
        /// <li>Gansu：甘肃。</li>
        /// <li>Qinghai：青海。</li>
        /// <li>Xinjiang：新疆。</li>
        /// <li>Heilongjiang：黑龙江。</li>
        /// <li>Jilin：吉林。</li>
        /// <li>Liaoning：辽宁。</li>
        /// <li>Fujian：福建。</li>
        /// <li>Jiangsu：江苏。</li>
        /// <li>Anhui：安徽。</li>
        /// <li>Shandong：山东。</li>
        /// <li>Shanghai：上海。</li>
        /// <li>Zhejiang：浙江。</li>
        /// <li>Henan：河南。</li>
        /// <li>Hubei：湖北。</li>
        /// <li>Jiangxi：江西。</li>
        /// <li>Hunan：湖南。</li>
        /// <li>Guizhou：贵州。</li>
        /// <li>Yunnan：云南。</li>
        /// <li>Chongqing：重庆。</li>
        /// <li>Sichuan：四川。</li>
        /// <li>Xizang：西藏。</li>
        /// <li>Guangdong：广东。</li>
        /// <li>Guangxi：广西。</li>
        /// <li>Hainan：海南。</li>
        /// <li>Hong Kong, Macao and Taiwan：港澳台。</li>
        /// <li>Outside Chinese Mainland：海外。</li>
        /// <li>Other：其他 。</li>
        /// </summary>
        [JsonProperty("Districts")]
        public string[] Districts{ get; set; }

        /// <summary>
        /// 用户所属运营商信息，Area 为 Chinese Mainland 时，取值为以下运营商信息。当 Area 为其它值时忽略 Isps 参数。
        /// <li>China Telecom：中国电信。 </li>
        /// <li>China Unicom：中国联通。 </li>
        /// <li>CERNET：教育网。</li>
        /// <li>Great Wall Broadband Network：长城宽带。</li>
        /// <li>China Mobile：中国移动。</li>
        /// <li>China Mobile Tietong：中国铁通。</li>
        /// <li>ISPs outside Chinese Mainland：海外运营商。</li>
        /// <li>Other ISPs：其他运营商。</li>
        /// </summary>
        [JsonProperty("Isps")]
        public string[] Isps{ get; set; }

        /// <summary>
        /// 每条数据的时间粒度，单位：分钟，取值有：
        /// <li>5：5 分钟粒度，返回指定查询时间内5分钟粒度的明细数据。</li>
        /// <li>1440：天粒度，返回指定查询时间内1天粒度的数据。起始时间和结束时间跨度大于24小时，只支持天粒度的数据。</li>
        /// 当 StartTime 和 EndTime 时间跨度大于24小时时，DataInterval 默认为 1440。
        /// </summary>
        [JsonProperty("DataInterval")]
        public ulong? DataInterval{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Metric", this.Metric);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamArraySimple(map, prefix + "DomainNames.", this.DomainNames);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamArraySimple(map, prefix + "Districts.", this.Districts);
            this.SetParamArraySimple(map, prefix + "Isps.", this.Isps);
            this.SetParamSimple(map, prefix + "DataInterval", this.DataInterval);
        }
    }
}

