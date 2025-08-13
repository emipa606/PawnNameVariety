# GitHub Copilot Instructions for Pawn Name Variety (Continued)

## Mod Overview and Purpose

**Pawn Name Variety (Continued)** is a RimWorld mod designed to enhance the diversity of pawn names in the game by unlocking thousands of potential name combinations. The mod achieves this by breaking down predefined pawn names into first, last, and nicknames, then inserting them into gender-specific name pools. This approach increases randomness and reduces repetition of familiar names from game to game, providing a fresher and more varied gameplay experience without affecting tribal and imperial pawns that have unique naming schemes.

## Key Features and Systems

- **Name Variety Enhancement**: Breaks down all predefined full names into components – first names, last names, and nicknames – and adds them to the random pools, dramatically increasing potential name combinations.
- **Backer Name Avoidance**: Prevents predefined 'backer' and 'name in game' names from appearing unless they are specifically added to the 'Preferred Player-Created Characters' list.
- **Duplicate Name Check**: Ensures no duplicate names are added to the pool, maintaining name variety.
- **Preferred Characters Support**: Allows favored characters named in the RimWorld options menu to still appear in games.
- **Nickname Rarity**: Reflects true randomness by having fewer pawns with nicknames, as most nicknames in vanilla are from predefined names.

## Coding Patterns and Conventions

- **C# Class Structure**: 
  - Unified naming conventions for classes and methods using PascalCase.
  - Classes are organized by functionality for better readability and maintenance.

- **Main Classes**:
  - `HarmonyPatcher`: Manages the application of Harmony patches to tweak or alter the game's systems.
  - `PawnBioAndNameGenerator_TryGetRandomUnusedSolidBioFor` and `PawnBioAndNameGenerator_TryGetRandomUnusedSolidName`: Handle the logic for fetching and generating bios and names.
  - `PNVMod` and `PNVSettings`: Responsible for managing mod initialization and settings.
  - `S`: Contains static methods or constants for shared or utility purposes.
  - `Startup`: Manages the startup logic pertinent to the mod.

## XML Integration

- XML files may be used to configure name generation rules or pools, ensuring mod data is easily manageable and extendable without needing to modify complex C# code directly.
- Ensure XML files follow a consistent formatting pattern for easier parsing and maintenance.

## Harmony Patching

- **Purpose and Use**: Harmony is utilized to patch methods within RimWorld, allowing the mod to intercept and modify existing game logic regarding name generation.
- **Key Practice**: Apply patches responsibly to maintain compatibility with other mods and ensure they are reversible to prevent residual effects when disabled.

## Suggestions for Copilot

- **Predictive Coding**: Incorporate predictive elements for generating random name combinations based on predefined rules.
- **Focus on Compatibility**: Suggest Harmony patches that ensure compatibility with expansion content and other mods.
- **Code Optimization**: Streamline methods within the `PawnBioAndNameGenerator_*` classes to efficiently handle large datasets of names.
- **Utility Functions**: Propose utility functions for XML parsing and name pool manipulation, enhancing code reuse across different parts of the mod.
- **Robust Error Handling**: Implement thorough exception handling and logging, which Copilot can help generate based on common patterns observed in similar mods.

The goal of these Copilot instructions is to assist with efficient code completion and problem solving within the context of enhancing name generation diversity in RimWorld. The instructions should be used as a reference for maintaining code quality and compatibility across various modded environments.
