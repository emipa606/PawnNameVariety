# GitHub Copilot Instructions for Pawn Name Variety (Continued)

## Mod Overview and Purpose
**Mod Name**: Pawn Name Variety (Continued)  
**Author**: Murmur  
**Description**: This mod enhances RimWorld's character naming system by introducing a wide variety of name combinations, reducing the prevalence of predefined names and increasing the uniqueness of each pawn. 

In RimWorld, many characters use predefined names and backstories, which can become repetitive. This mod adds a layer of variability by breaking existing predefined full names into first, last, and nick names, which are then shuffled into the name generation pool, resulting in thousands of potential new combinations. This allows for a more diverse and immersive colony experience.

## Key Features and Systems
- **Random Name Generation**: The mod dismantles existing full names into separate first, last, and nick names, thus enabling novel combinations.
- **Variety Expansion**: Introduces thousands of new name combinations without adding entirely new names, just by reconfiguring existing ones.
- **Selective Exclusion**: Prevents predefined 'backer pawns' or 'name in game' names from appearing, unless they're added to the 'Preferred Player-Created Characters' list.
- **Duplicate Check**: The mod checks for duplicate names, ensuring each name in the pool is unique.
- **Preserved Favorites**: Users can still see favored characters by adding their names to the list in the settings.
- **Limited Nicknames**: With no predefined names, nicknames become a rare feature in randomly generated pawns.

## Coding Patterns and Conventions
- **C# Directory Setup**: C# files are organized in `\Source\PawnNameVariety\` for clear structure and accessibility.
- **Namespaces and Classes**: Each functionality is encapsulated within specific namespaces and classes reflecting its purpose, such as `HarmonyPatcher` and `PNVMod`.
- **Comments**: Comments are vital for understanding the logic and flow, especially in methods that manipulate XML and apply Harmony patches.
- **Method Naming**: Use PascalCase for method names (e.g., `DoSettingsWindowContents`, `WriteSettings`).

## XML Integration
- **File Path**: XML files are stored in paths like `\Source\About.xml`.
- **Dependencies Management**: Handle mod dependencies using XML tags. The file `About.xml` references the Harmony library as a dependency for required patches.
- **Configuration**: Any changes or configurations affecting game data (like names) should be verified in XML files.

## Harmony Patching
- **Purpose**: Harmony patches are used to override or extend game behaviors related to name generation without altering the core files.
- **Patch Location**: These patches can be found in files such as `HarmonyPatcher.cs`, where patching and postfix methods are defined.
- **Postfix Methods**: Used to execute additional code after the original method, such as in `PawnBioAndNameGenerator_TryGetRandomUnusedSolidBioFor`.
- **Debugging**: Ensure you log errors elegantly to assist in debugging. Use Harmony’s built-in methods to troubleshoot patch conflicts.

## Suggestions for Copilot
- **Name Matching Logic**: Enhance Copilot suggestions by improving name parsing and duplicate checking logic using string manipulation techniques.
- **Harmony Patches Automation**: Propose creative ways to automate the creation of Harmony patches for new name components.
- **Unit Testing**: Suggest unit tests for methods that alter pawns' names to prevent unexpected behaviors when new combinations are added.
- **Mod Compatibility Checks**: Provide insights on creating checks that ensure compatibility with other mods altering name tables.

Utilize GitHub Copilot to optimize your C# logic, streamline XML processing, and handle dynamic game behaviors efficiently by embracing these conventions and suggestions.

## Project Solution Guidelines
- Relevant mod XML files are included as Solution Items under the solution folder named XML, these can be read and modified from within the solution.
- Use these in-solution XML files as the primary files for reference and modification.
- The `.github/copilot-instructions.md` file is included in the solution under the `.github` solution folder, so it should be read/modified from within the solution instead of using paths outside the solution. Update this file once only, as it and the parent-path solution reference point to the same file in this workspace.
- When making functional changes in this mod, ensure the documented features stay in sync with implementation; use the in-solution `.github` copy as the primary file.
- In the solution is also a project called Assembly-CSharp, containing a read-only version of the decompiled game source, for reference and debugging purposes.
- For any new documentation, update this copilot-instructions.md file rather than creating separate documentation files.


## Hard rules (must follow)
- Do NOT run commands that modify the repo (no git commit, git apply, dotnet format) unless explicitly asked.
- Prefer minimal reads: read only the smallest code region needed (around the suspicious lines).
- When mentioning SonarQube issues, automatically use the SonarQube MCP service to fetch and address issues instead of making inferred fixes without querying SonarQube first.
- When mentioning the rimworld log, automatically use the Rimworld MCP service to fetch the log.

