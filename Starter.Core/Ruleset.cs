namespace Starter.Core
{
    /// <summary>
    /// Information about the ruleset being used to run this game.
    /// TODO: rules.
    /// TODO: Add rule for avoiding the wall.
    /// TODO: Add rule for avoiding snakes (self and others).
    /// TODO: Add rule to eat food when hungry.
    /// </summary>
    public class Ruleset
    {
        /// <summary>
        /// Avoid walls.
        /// </summary>
        /// TODO: Add more rules.
        /// public string AvoidWalls = "AvoidWalls";

        /// public string AvoidSnakes = "AvoidSnakes";

        /// public string EatFood = "EatFood";
        

        public string Name { get; set; }


        /// <summary>
        /// The version of the ruleset.
        /// Example: "v1.2.3"
        /// </summary>
        public string Version { get; set; }

    }
}
