/*
 *
 * Copyright 2015 gRPC authors.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 */

#include <grpc/impl/codegen/port_platform.h>

#include "src/core/lib/gpr/useful.h"

#include <gtest/gtest.h>

namespace grpc_core {

TEST(UsefulTest, ClampWorks) {
  EXPECT_EQ(grpc_core::Clamp(1, 0, 2), 1);
  EXPECT_EQ(grpc_core::Clamp(0, 0, 2), 0);
  EXPECT_EQ(grpc_core::Clamp(2, 0, 2), 2);
  EXPECT_EQ(grpc_core::Clamp(-1, 0, 2), 0);
  EXPECT_EQ(grpc_core::Clamp(3, 0, 2), 2);
}

TEST(UsefulTest, Rotate) {
  EXPECT_EQ(grpc_core::RotateLeft(0x80000001u, 1u), 3);
  EXPECT_EQ(grpc_core::RotateRight(0x80000001u, 1u), 0xc0000000);
}

TEST(UsefulTest, ArraySize) {
  int four[4];
  int five[5];

  EXPECT_EQ(GPR_ARRAY_SIZE(four), 4);
  EXPECT_EQ(GPR_ARRAY_SIZE(five), 5);
}

TEST(UsefulTest, BitOps) {
  uint32_t bitset = 0;

  EXPECT_EQ(grpc_core::BitCount((1u << 31) - 1), 31);
  EXPECT_EQ(grpc_core::BitCount(1u << 3), 1);
  EXPECT_EQ(grpc_core::BitCount(0), 0);
  EXPECT_EQ(grpc_core::SetBit(&bitset, 3), 8);
  EXPECT_EQ(grpc_core::BitCount(bitset), 1);
  EXPECT_EQ(grpc_core::GetBit(bitset, 3), 1);
  EXPECT_EQ(grpc_core::SetBit(&bitset, 1), 10);
  EXPECT_EQ(grpc_core::BitCount(bitset), 2);
  EXPECT_EQ(grpc_core::ClearBit(&bitset, 3), 2);
  EXPECT_EQ(grpc_core::BitCount(bitset), 1);
  EXPECT_EQ(grpc_core::GetBit(bitset, 3), 0);
}

}  // namespace grpc_core

int main(int argc, char** argv) {
  ::testing::InitGoogleTest(&argc, argv);
  return RUN_ALL_TESTS();
}
